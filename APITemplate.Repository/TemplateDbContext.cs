using System;
namespace APITemplate.Repository
{
	public class TemplateDbContext
	{
		public int[] List { get; set; } = new int[3] { 1, 2, 3 };

		public TemplateDbContext()
		{
		}
	}
}

