﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PageModel.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using BetterCms.Module.Api.Infrastructure;
using BetterCms.Module.Api.Operations.Pages.Pages.Page.Properties;
using BetterCms.Module.Api.Operations.Root;

namespace BetterCms.Module.Api.Operations.Pages.Pages
{
    [DataContract]
    [System.Serializable]
    public class PageModel : ModelBase
    {
        /// <summary>
        /// Gets or sets the page URL.
        /// </summary>
        /// <value>
        /// The page URL.
        /// </value>
        [DataMember]
        public string PageUrl { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the page status.
        /// </summary>
        /// <value>
        /// The page status.
        /// </value>
        [DataMember]
        public bool IsPublished { get; set; }

        /// <summary>
        /// Gets or sets the page published date.
        /// </summary>
        /// <value>
        /// The page published date.
        /// </value>
        [DataMember]
        public System.DateTime? PublishedOn { get; set; }

        /// <summary>
        /// Gets or sets the page layout id.
        /// </summary>
        /// <value>
        /// The page layout id.
        /// </value>
        [DataMember]
        public System.Guid? LayoutId { get; set; }

        /// <summary>
        /// Gets or sets the master page id.
        /// </summary>
        /// <value>
        /// The master page id.
        /// </value>
        [DataMember]
        public System.Guid? MasterPageId { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The category id.
        /// </value>
        [DataMember]
        public List<CategoryModel> Categories { get; set; }


        /// <summary>
        /// Gets or sets the blog posts main image id.
        /// </summary>
        /// <value>
        /// The blog post main image id.
        /// </value>
        [DataMember]
        public System.Guid? MainImageId { get; set; }

        /// <summary>
        /// Gets or sets the main image URL.
        /// </summary>
        /// <value>
        /// The main image URL.
        /// </value>
        [DataMember]
        public string MainImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the main image thumbnauil URL.
        /// </summary>
        /// <value>
        /// The main image thumbnauil URL.
        /// </value>
        [Obsolete]
        [DataMember]
        public string MainImageThumbnauilUrl { get; set; }

        /// <summary>
        /// Gets or sets the main image thumbnail URL.
        /// </summary>
        /// <value>
        /// The main image thumbnail URL.
        /// </value>
        [DataMember]
        public string MainImageThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets the main image caption.
        /// </summary>
        /// <value>
        /// The main image caption.
        /// </value>
        [DataMember]
        public string MainImageCaption { get; set; }


        /// <summary>
        /// Gets or sets secondary image id.
        /// </summary>
        /// <value>
        /// The blog post secondary image id.
        /// </value>
        [DataMember]
        public System.Guid? SecondaryImageId { get; set; }

        /// <summary>
        /// Gets or sets the secondary image URL.
        /// </summary>
        /// <value>
        /// The secondary image URL.
        /// </value>
        [DataMember]
        public string SecondaryImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the secondary image thumbnail URL.
        /// </summary>
        /// <value>
        /// The secondary image thumbnail URL.
        /// </value>
        [DataMember]
        public string SecondaryImageThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets the secondary image caption.
        /// </summary>
        /// <value>
        /// The secondary image caption.
        /// </value>
        [DataMember]
        public string SecondaryImageCaption { get; set; }


        /// <summary>
        /// Gets or sets featured image id.
        /// </summary>
        /// <value>
        /// The blog post featured image id.
        /// </value>
        [DataMember]
        public System.Guid? FeaturedImageId { get; set; }

        /// <summary>
        /// Gets or sets the featured image URL.
        /// </summary>
        /// <value>
        /// The featured image URL.
        /// </value>
        [DataMember]
        public string FeaturedImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the featured image thumbnail URL.
        /// </summary>
        /// <value>
        /// The featured image thumbnail URL.
        /// </value>
        [DataMember]
        public string FeaturedImageThumbnailUrl { get; set; }

        /// <summary>
        /// Gets or sets the featured image caption.
        /// </summary>
        /// <value>
        /// The featured image caption.
        /// </value>
        [DataMember]
        public string FeaturedImageCaption { get; set; }


        /// <summary>
        /// Gets or sets a value indicating whether page is marked as archived.
        /// </summary>
        /// <value>
        /// <c>true</c> if page is marked as archived; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        [DataMember]
        public System.Collections.Generic.List<OptionValueModel> Options  { get; set; }

        /// <summary>
        /// Gets or sets the list of tag names.
        /// </summary>
        /// <value>
        /// The list of tag names.
        /// </value>
        [DataMember]
        public System.Collections.Generic.List<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the list of access rule models.
        /// </summary>
        /// <value>
        /// The list of access rule models.
        /// </value>
        [DataMember]
        public System.Collections.Generic.List<AccessRuleModel> AccessRules { get; set; }

        /// <summary>
        /// Gets or sets the page metadata.
        /// </summary>
        /// <value>
        /// The page metadata.
        /// </value>
        [DataMember]
        public MetadataModel Metadata { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a page is a master page.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the page is a master page; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsMasterPage { get; set; }

        /// <summary>
        /// Gets or sets the language id.
        /// </summary>
        /// <value>
        /// The language id.
        /// </value>
        [DataMember]
        public System.Guid? LanguageId { get; set; }

        /// <summary>
        /// Gets or sets the language code.
        /// </summary>
        /// <value>
        /// The language code.
        /// </value>
        [DataMember]
        public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the language group identifier.
        /// </summary>
        /// <value>
        /// The language group identifier.
        /// </value>
        [DataMember]
        public System.Guid? LanguageGroupIdentifier { get; set; }
    }
}