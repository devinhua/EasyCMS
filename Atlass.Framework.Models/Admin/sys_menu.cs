//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Atlass.Framework.Models {

	
	public partial class sys_menu {

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string create_person { get; set; } = string.Empty;

		[JsonProperty]
		public DateTime create_time { get; set; }

		[JsonProperty]
		public long id { get; set; }

		[JsonProperty, Column(DbType = "tinyint(1)")]
		public bool iframe { get; set; }

		[JsonProperty, Column(DbType = "varchar(20)")]
		public string menu_icon { get; set; } = string.Empty;

		[JsonProperty, Column(DbType = "tinyint(4)")]
		public int menu_level { get; set; }

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string menu_name { get; set; } = string.Empty;

		[JsonProperty]
		public int menu_sort { get; set; }

		[JsonProperty, Column(DbType = "tinyint(4)")]
		public sbyte menu_type { get; set; }

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string menu_url { get; set; } = string.Empty;

		[JsonProperty]
		public long parent_id { get; set; }

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string remark { get; set; } = string.Empty;

	}

}
