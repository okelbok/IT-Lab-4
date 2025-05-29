using System.Windows.Forms;

namespace Lab4_IT.Utils 
{
	internal static class MessageHandler 
	{
		public static void showError (string error, string errorType) 
		{
			MessageBox.Show(error, errorType, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void showResult(string result, string resultType)
		{
			MessageBox.Show(result, resultType, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
