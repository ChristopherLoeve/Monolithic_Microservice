using AuthorsService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorsService.Data
{
	public class Repository
	{
		private IEnumerable<Author> _authors { get; set; }

		public Repository()
		{
			_authors = new[]
			{
				new Author
				{
					AuthorId = 1,
					Name = "John Doe"
				},
				new Author
				{
					AuthorId = 2,
					Name = "Jane Smith"
				}
			};
		}

		public IEnumerable<Author> GetAuthors() => _authors;
	}
}
