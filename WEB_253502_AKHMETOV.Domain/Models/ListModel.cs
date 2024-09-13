using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_253502_AKHMETOV.Domain.Models
{
	public class ListModel<T>
	{
		public List<T> Items { get; set; } = new List<T>();

		public int CurrentPage { get; set; } = 1;

		public int TotalPages { get; set; } = 1;
	}
}
