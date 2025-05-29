using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

using Lab4_IT.Algorithms;
using Lab4_IT.Utils;

namespace Lab4_IT 
{
	public partial class MainForm : Form 
	{
		private readonly Dictionary<string, string> requirements = new Dictionary<string, string>();

		public MainForm() 
		{
			InitializeComponent();

			requirements.Add("Q", "Введите простое число Q.");
			requirements.Add("P", "Введите простое число P такое, что Q является делителем (P - 1).");
			requirements.Add("H", "Введите число H из интервала (1; P - 1).");
			requirements.Add("X", "Введите число X из интервала (0; Q).");
			requirements.Add("K", "Введите число K из интервала (0; Q).");

			requirements.Add("G", "Число G = (H ^ ((P - 1) / Q)) mod Q должно быть строго больше 1.");
			requirements.Add("R|S", "Числа R и S, составляющие ЭЦП, не должны быть равны 0.");
		}

		private BigInteger validateIntegerInput(string text, string name, Func<BigInteger, bool> isValid) 
		{
			text = text.Trim();

			if (text.Equals("")) {
				MessageHandler.showError(
					"Не введён параметр " + name + ". "+ requirements[name], 
					"Ошибка ввода параметров"
				);

				throw new Exception();
			}

			BigInteger value;

			try
			{
				value = BigInteger.Parse(text);
			}
			catch
			{
				MessageHandler.showError(
						"Для параметра " + name + " введено не числовое значение. " + requirements[name],
						"Ошибка ввода параметров"
				);

				throw new Exception();
			}

			if (!isValid(value))
			{
				MessageHandler.showError(
						"Параметр " + name + " введён некорректно. " + requirements[name],
						"Ошибка ввода параметров"
				);

				throw new Exception();
			}

			return value;
		}

		private BigInteger calculateG(BigInteger h, BigInteger p, BigInteger q)
		{
			BigInteger g = ModularAlgoritms.fastExponentialPower(h, (p - 1) / q, p);

			if (g < 2)
			{
				MessageHandler.showError(
						"Параметр G не соответствует условиям. " + requirements["G"],
						"Ошибка вычисления параметров"
				);

				throw new Exception();
			}

			return g;
		}

		private void clearResultFields()
		{
			GTextBox.Clear();
			YTextBox.Clear();

			HashTextBox.Clear();
			EDSTextBox.Clear();

			ResultTextBox.Clear();
		}

		private void signText(BigInteger q, BigInteger p, BigInteger x, BigInteger k, BigInteger g)
		{
			string M = InitialTextBox.Text;
			BigInteger hash = 0, r, s;

			(r, s) = DSA.sign(q, p, x, k, g, ref hash, M);

			HashTextBox.Text = $"{hash}";

			if (r == 0 || s == 0)
			{
				MessageHandler.showError(
					"В результате вычислений R = 0 или S = 0. Введите другое K.",
					"Ошибка вычисления ЭЦП"
				);
				KTextBox.Clear();

				return;
			}

			EDSTextBox.Text = $"{r} {s}";
			ResultTextBox.Text = $"{M} " + EDSTextBox.Text;
		}

		private void verifyTextSignature(
			BigInteger q, BigInteger p, BigInteger h, BigInteger x, BigInteger k, 
			BigInteger g, BigInteger y)
		{
			string signedM = InitialTextBox.Text;
			BigInteger hash = 0, r, s, v;

			string[] signedMParts = signedM.Split(' ');
			
			signedM = string.Join(" ", signedMParts.Take(signedMParts.Length - 2));

			try
			{
				r = BigInteger.Parse(signedMParts[signedMParts.Length - 2]);
				s = BigInteger.Parse(signedMParts[signedMParts.Length - 1]);

				if (r == 0 || s == 0)
				{
					throw new Exception();
				}
			}
			catch
			{
				MessageHandler.showError(
					"Значение R или S не числовое либо равно нулю. Повторите ввод.",
					"Ошибка парсинга подписанного текста"
				);
				return;
			}

			EDSTextBox.Text = $"{r} {s}";

			v = DSA.verify(q, p, g, y, r, s, ref hash, signedM);

			HashTextBox.Text = $"{hash}";

			if (v == r)
			{
				MessageHandler.showResult(
					$"Подпись верна, v = {v} = r = {r}.",
					"Проверка подписи"
				);
			}
			else
			{
				MessageHandler.showError(
					$"Подпись неверна, v = {v} != r = {r}.",
					"Проверка подписи"
				);
			}
		}

		private void EDSActionButton_Click(object sender, EventArgs e)
		{
			BigInteger q, p, h, x, k;
			BigInteger g, y = 0, hash = 0, r = 0, s = 0;

			try
			{
				q = validateIntegerInput(QTextBox.Text, "Q", (value) => ModularAlgoritms.isPrime(value));
				p = validateIntegerInput(PTextBox.Text, "P", (value) => ModularAlgoritms.isPrime(value) && (value - 1) % q == 0);
				h = validateIntegerInput(HTextBox.Text, "H", (value) => (value > 1) && (value < p - 1));
				x = validateIntegerInput(XTextBox.Text, "X", (value) => (value > 0) && (value < q));
				k = validateIntegerInput(KTextBox.Text, "K", (value) => (value > 0) && (value < q));

				g = calculateG(h, p, q);
			}
			catch (Exception)
			{
				clearResultFields();
				return;
			}

			y = ModularAlgoritms.fastExponentialPower(g, x, p);

			GTextBox.Text = $"{g}";
			YTextBox.Text = $"{y}";

			if (SignRadioButton.Checked)
			{
				signText(q, p, x, k, g);
			}
			else if (VerifySignatureRadioButton.Checked)
			{
				verifyTextSignature(q, p, h, x, k, g, y);
			}
		}

		private void InputButton_Click(object sender, EventArgs e)
		{
			if (InputDialog.ShowDialog() == DialogResult.OK)
			{
				clearResultFields();

				InitialTextBox.Text = File.ReadAllText(InputDialog.FileName);
			}
		}

		private void OutputButton_Click(object sender, EventArgs e)
		{
			if (ResultTextBox.Text.Length > 0)
			{
				if (OutputDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(OutputDialog.FileName, ResultTextBox.Text);
				}
			}
			else
			{
				MessageHandler.showError(
					"Полученный текст не должен быть пустым.", 
					"Ошибка записи"
				);
			}
		}

		private void ClearFieldsButton_Click(object sender, EventArgs e)
		{
			QTextBox.Clear();
			PTextBox.Clear();
			HTextBox.Clear();
			XTextBox.Clear();
			KTextBox.Clear();

			InitialTextBox.Clear();

			clearResultFields();
		}

		private void RadioButton_CheckedChanged(object sender, EventArgs e)
		{
			EDSActionButton.Enabled = (sender as RadioButton).Checked;
		}

		private void ParameterTextBox_TextChanged(object sender, EventArgs e)
		{
			clearResultFields();
		}
	}
}
