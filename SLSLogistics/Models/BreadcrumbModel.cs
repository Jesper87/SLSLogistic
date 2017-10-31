namespace SLSLogistics.Models
{
	public class BreadcrumbModel
	{
		public BreadcrumbModel(string activePageDisplayName)
		{
			ActivePageDisplayName = activePageDisplayName;
		}

		public string ActivePageDisplayName { get; set; }
	}
}