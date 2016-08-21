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
			double firstGrade = double.Parse(firstGradeEntry.Text);
			double lastGrade = double.Parse(lastGradeEntry.Text);

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

