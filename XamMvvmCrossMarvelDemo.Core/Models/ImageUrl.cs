﻿using System;
using Newtonsoft.Json;

namespace XamMvvmCorssMarvelDemo.Core.Models
{
	public class ImageUrl
	{
		[JsonProperty("path")]
		public string Path { get; set; }
		[JsonProperty("extension")]
		public string Extension { get; set; }
	}
}

