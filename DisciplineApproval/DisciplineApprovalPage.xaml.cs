using Xamarin.Forms;

namespace DisciplineApproval
{
	public partial class DisciplineApprovalPage : ContentPage
	{
		public DisciplineApprovalPage()
		{
			InitializeComponent();
		}

		void CheckApprovation(object sender, System.EventArgs e)
		{
			double firstGrade;
			double lastGrade;

			bool isFirstGradeValid = double.TryParse(firstGradeEntry.Text, out firstGrade);
			bool isLastGradeValid = double.TryParse(lastGradeEntry.Text, out lastGrade);

			if (!isFirstGradeValid || !isLastGradeValid)
			{
				result.Text = "Informe as duas notas.";
				return;
			}

			double finalAvg = (firstGrade * 0.4) + (lastGrade * 0.6);

			if (finalAvg >= 6)
			{
				result.Text = "Passou, parabéns!";
			}
			else if (finalAvg >= 4)
			{
				result.Text = "Na trave, mas ainda pode fazer a prova final.";
			}
			else
			{
				result.Text = "Xi, não.";
			}
		}
	}
}

