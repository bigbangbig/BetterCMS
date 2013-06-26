﻿using System.Runtime.Serialization;

namespace BetterCms.Module.WebApi.Models.Root.GetCategoryByName
{
    [DataContract]
    public class CategoryModel : ModelBase
    {
        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        /// <value>
        /// The category name.
        /// </value>
        [DataMember(Order = 10, Name = "name")]
        public string Name { get; set; }
    }
}