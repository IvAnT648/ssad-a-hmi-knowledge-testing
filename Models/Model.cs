using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge_Testing.Models
{
	class Model
	{
		protected int Id = 0;
		protected string TableName = "";
		protected string PrimaryKeyName = "id";
		protected Dictionary<string, dynamic> Fields = new Dictionary<string, dynamic>();

		public int GetId()
		{
			return Id;
		}

		public bool Exists()
		{
			return Convert.ToBoolean(Id);
		}

		public T GetData<T>(string key)
		{
			return (T)Fields[key];
		}

		public Model SetData(string key, dynamic value)
		{
			Fields.Add(key, value);
			return this;
		}
	}
}
