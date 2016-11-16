//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.4.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "c97f789619e8234f")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.2")]

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1086 with alias "sEO"
	/// <summary>SEO</summary>
	public partial interface ISEO : IPublishedContent
	{
		/// <summary>meta Description</summary>
		string MetaDescription { get; }

		/// <summary>meta Title</summary>
		string MetaTitle { get; }
	}

	/// <summary>SEO</summary>
	[PublishedContentModel("sEO")]
	public partial class SEO : PublishedContentModel, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "sEO";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SEO(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SEO, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return GetMetaDescription(this); }
		}

		/// <summary>Static getter for meta Description</summary>
		public static string GetMetaDescription(ISEO that) { return that.GetPropertyValue<string>("metaDescription"); }

		///<summary>
		/// meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return GetMetaTitle(this); }
		}

		/// <summary>Static getter for meta Title</summary>
		public static string GetMetaTitle(ISEO that) { return that.GetPropertyValue<string>("metaTitle"); }
	}

	// Mixin content Type 1088 with alias "umbracoSettings"
	/// <summary>umbraco Settings</summary>
	public partial interface IUmbracoSettings : IPublishedContent
	{
		/// <summary>umbraco Internal Redirect Id</summary>
		object UmbracoInternalRedirectId { get; }

		/// <summary>umbraco Navi Hide</summary>
		bool UmbracoNaviHide { get; }

		/// <summary>umbraco Redirect</summary>
		object UmbracoRedirect { get; }

		/// <summary>umbraco Sitemap Hide</summary>
		bool UmbracoSitemapHide { get; }

		/// <summary>umbraco Url Alias</summary>
		string UmbracoUrlAlias { get; }

		/// <summary>umbraco Url Name</summary>
		string UmbracoUrlName { get; }
	}

	/// <summary>umbraco Settings</summary>
	[PublishedContentModel("umbracoSettings")]
	public partial class UmbracoSettings : PublishedContentModel, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "umbracoSettings";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public UmbracoSettings(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UmbracoSettings, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return GetUmbracoInternalRedirectId(this); }
		}

		/// <summary>Static getter for umbraco Internal Redirect Id</summary>
		public static object GetUmbracoInternalRedirectId(IUmbracoSettings that) { return that.GetPropertyValue("umbracoInternalRedirectId"); }

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return GetUmbracoNaviHide(this); }
		}

		/// <summary>Static getter for umbraco Navi Hide</summary>
		public static bool GetUmbracoNaviHide(IUmbracoSettings that) { return that.GetPropertyValue<bool>("umbracoNaviHide"); }

		///<summary>
		/// umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return GetUmbracoRedirect(this); }
		}

		/// <summary>Static getter for umbraco Redirect</summary>
		public static object GetUmbracoRedirect(IUmbracoSettings that) { return that.GetPropertyValue("umbracoRedirect"); }

		///<summary>
		/// umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return GetUmbracoSitemapHide(this); }
		}

		/// <summary>Static getter for umbraco Sitemap Hide</summary>
		public static bool GetUmbracoSitemapHide(IUmbracoSettings that) { return that.GetPropertyValue<bool>("umbracoSitemapHide"); }

		///<summary>
		/// umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return GetUmbracoUrlAlias(this); }
		}

		/// <summary>Static getter for umbraco Url Alias</summary>
		public static string GetUmbracoUrlAlias(IUmbracoSettings that) { return that.GetPropertyValue<string>("umbracoUrlAlias"); }

		///<summary>
		/// umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return GetUmbracoUrlName(this); }
		}

		/// <summary>Static getter for umbraco Url Name</summary>
		public static string GetUmbracoUrlName(IUmbracoSettings that) { return that.GetPropertyValue<string>("umbracoUrlName"); }
	}

	/// <summary>home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, ISEO, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// site Name
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}

		///<summary>
		/// meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return SEO.GetMetaTitle(this); }
		}

		///<summary>
		/// umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return UmbracoSettings.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return UmbracoSettings.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return UmbracoSettings.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return UmbracoSettings.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return UmbracoSettings.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return UmbracoSettings.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>page</summary>
	[PublishedContentModel("page")]
	public partial class Page : PublishedContentModel, IBasicContent, ISEO, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "page";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Page(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Page, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Dropdown Partners
		///</summary>
		[ImplementPropertyType("dropdownPartners")]
		public object DropdownPartners
		{
			get { return BasicContent.GetDropdownPartners(this); }
		}

		///<summary>
		/// heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return BasicContent.GetHeading(this); }
		}

		///<summary>
		/// image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return BasicContent.GetImage(this); }
		}

		///<summary>
		/// Links
		///</summary>
		[ImplementPropertyType("links")]
		public Newtonsoft.Json.Linq.JArray Links
		{
			get { return BasicContent.GetLinks(this); }
		}

		///<summary>
		/// main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return BasicContent.GetMainContent(this); }
		}

		///<summary>
		/// part
		///</summary>
		[ImplementPropertyType("part")]
		public object Part
		{
			get { return BasicContent.GetPart(this); }
		}

		///<summary>
		/// meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return SEO.GetMetaTitle(this); }
		}

		///<summary>
		/// umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return UmbracoSettings.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return UmbracoSettings.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return UmbracoSettings.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return UmbracoSettings.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return UmbracoSettings.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return UmbracoSettings.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>branch</summary>
	[PublishedContentModel("branch")]
	public partial class Branch : PublishedContentModel, IBasicContent, ISEO, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "branch";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Branch(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Branch, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Dropdown Partners
		///</summary>
		[ImplementPropertyType("dropdownPartners")]
		public object DropdownPartners
		{
			get { return BasicContent.GetDropdownPartners(this); }
		}

		///<summary>
		/// heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return BasicContent.GetHeading(this); }
		}

		///<summary>
		/// image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return BasicContent.GetImage(this); }
		}

		///<summary>
		/// Links
		///</summary>
		[ImplementPropertyType("links")]
		public Newtonsoft.Json.Linq.JArray Links
		{
			get { return BasicContent.GetLinks(this); }
		}

		///<summary>
		/// main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return BasicContent.GetMainContent(this); }
		}

		///<summary>
		/// part
		///</summary>
		[ImplementPropertyType("part")]
		public object Part
		{
			get { return BasicContent.GetPart(this); }
		}

		///<summary>
		/// meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return SEO.GetMetaTitle(this); }
		}

		///<summary>
		/// umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return UmbracoSettings.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return UmbracoSettings.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return UmbracoSettings.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return UmbracoSettings.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return UmbracoSettings.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return UmbracoSettings.GetUmbracoUrlName(this); }
		}
	}

	// Mixin content Type 1115 with alias "basicContent"
	/// <summary>basic Content</summary>
	public partial interface IBasicContent : IPublishedContent
	{
		/// <summary>Dropdown Partners</summary>
		object DropdownPartners { get; }

		/// <summary>heading</summary>
		string Heading { get; }

		/// <summary>image</summary>
		string Image { get; }

		/// <summary>Links</summary>
		Newtonsoft.Json.Linq.JArray Links { get; }

		/// <summary>main Content</summary>
		IHtmlString MainContent { get; }

		/// <summary>part</summary>
		object Part { get; }
	}

	/// <summary>basic Content</summary>
	[PublishedContentModel("basicContent")]
	public partial class BasicContent : PublishedContentModel, IBasicContent
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "basicContent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BasicContent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BasicContent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Dropdown Partners
		///</summary>
		[ImplementPropertyType("dropdownPartners")]
		public object DropdownPartners
		{
			get { return GetDropdownPartners(this); }
		}

		/// <summary>Static getter for Dropdown Partners</summary>
		public static object GetDropdownPartners(IBasicContent that) { return that.GetPropertyValue("dropdownPartners"); }

		///<summary>
		/// heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return GetHeading(this); }
		}

		/// <summary>Static getter for heading</summary>
		public static string GetHeading(IBasicContent that) { return that.GetPropertyValue<string>("heading"); }

		///<summary>
		/// image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return GetImage(this); }
		}

		/// <summary>Static getter for image</summary>
		public static string GetImage(IBasicContent that) { return that.GetPropertyValue<string>("image"); }

		///<summary>
		/// Links
		///</summary>
		[ImplementPropertyType("links")]
		public Newtonsoft.Json.Linq.JArray Links
		{
			get { return GetLinks(this); }
		}

		/// <summary>Static getter for Links</summary>
		public static Newtonsoft.Json.Linq.JArray GetLinks(IBasicContent that) { return that.GetPropertyValue<Newtonsoft.Json.Linq.JArray>("links"); }

		///<summary>
		/// main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return GetMainContent(this); }
		}

		/// <summary>Static getter for main Content</summary>
		public static IHtmlString GetMainContent(IBasicContent that) { return that.GetPropertyValue<IHtmlString>("mainContent"); }

		///<summary>
		/// part
		///</summary>
		[ImplementPropertyType("part")]
		public object Part
		{
			get { return GetPart(this); }
		}

		/// <summary>Static getter for part</summary>
		public static object GetPart(IBasicContent that) { return that.GetPropertyValue("part"); }
	}

	/// <summary>news Article</summary>
	[PublishedContentModel("newsArticle")]
	public partial class NewsArticle : PublishedContentModel, IBasicContent, ISEO, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "newsArticle";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public NewsArticle(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NewsArticle, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Dropdown Partners
		///</summary>
		[ImplementPropertyType("dropdownPartners")]
		public object DropdownPartners
		{
			get { return BasicContent.GetDropdownPartners(this); }
		}

		///<summary>
		/// heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return BasicContent.GetHeading(this); }
		}

		///<summary>
		/// image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return BasicContent.GetImage(this); }
		}

		///<summary>
		/// Links
		///</summary>
		[ImplementPropertyType("links")]
		public Newtonsoft.Json.Linq.JArray Links
		{
			get { return BasicContent.GetLinks(this); }
		}

		///<summary>
		/// main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return BasicContent.GetMainContent(this); }
		}

		///<summary>
		/// part
		///</summary>
		[ImplementPropertyType("part")]
		public object Part
		{
			get { return BasicContent.GetPart(this); }
		}

		///<summary>
		/// meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return SEO.GetMetaTitle(this); }
		}

		///<summary>
		/// umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return UmbracoSettings.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return UmbracoSettings.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return UmbracoSettings.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return UmbracoSettings.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return UmbracoSettings.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return UmbracoSettings.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>event</summary>
	[PublishedContentModel("event")]
	public partial class Event : PublishedContentModel, IBasicContent, ISEO, IUmbracoSettings
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "event";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Event(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Event, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// end Date
		///</summary>
		[ImplementPropertyType("endDate")]
		public DateTime EndDate
		{
			get { return this.GetPropertyValue<DateTime>("endDate"); }
		}

		///<summary>
		/// end Time
		///</summary>
		[ImplementPropertyType("endTime")]
		public DateTime EndTime
		{
			get { return this.GetPropertyValue<DateTime>("endTime"); }
		}

		///<summary>
		/// location
		///</summary>
		[ImplementPropertyType("location")]
		public string Location
		{
			get { return this.GetPropertyValue<string>("location"); }
		}

		///<summary>
		/// start Date
		///</summary>
		[ImplementPropertyType("start")]
		public DateTime Start
		{
			get { return this.GetPropertyValue<DateTime>("start"); }
		}

		///<summary>
		/// start Time
		///</summary>
		[ImplementPropertyType("startTime")]
		public DateTime StartTime
		{
			get { return this.GetPropertyValue<DateTime>("startTime"); }
		}

		///<summary>
		/// Dropdown Partners
		///</summary>
		[ImplementPropertyType("dropdownPartners")]
		public object DropdownPartners
		{
			get { return BasicContent.GetDropdownPartners(this); }
		}

		///<summary>
		/// heading
		///</summary>
		[ImplementPropertyType("heading")]
		public string Heading
		{
			get { return BasicContent.GetHeading(this); }
		}

		///<summary>
		/// image
		///</summary>
		[ImplementPropertyType("image")]
		public string Image
		{
			get { return BasicContent.GetImage(this); }
		}

		///<summary>
		/// Links
		///</summary>
		[ImplementPropertyType("links")]
		public Newtonsoft.Json.Linq.JArray Links
		{
			get { return BasicContent.GetLinks(this); }
		}

		///<summary>
		/// main Content
		///</summary>
		[ImplementPropertyType("mainContent")]
		public IHtmlString MainContent
		{
			get { return BasicContent.GetMainContent(this); }
		}

		///<summary>
		/// part
		///</summary>
		[ImplementPropertyType("part")]
		public object Part
		{
			get { return BasicContent.GetPart(this); }
		}

		///<summary>
		/// meta Description
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// meta Title
		///</summary>
		[ImplementPropertyType("metaTitle")]
		public string MetaTitle
		{
			get { return SEO.GetMetaTitle(this); }
		}

		///<summary>
		/// umbraco Internal Redirect Id
		///</summary>
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public object UmbracoInternalRedirectId
		{
			get { return UmbracoSettings.GetUmbracoInternalRedirectId(this); }
		}

		///<summary>
		/// umbraco Navi Hide
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return UmbracoSettings.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// umbraco Redirect
		///</summary>
		[ImplementPropertyType("umbracoRedirect")]
		public object UmbracoRedirect
		{
			get { return UmbracoSettings.GetUmbracoRedirect(this); }
		}

		///<summary>
		/// umbraco Sitemap Hide
		///</summary>
		[ImplementPropertyType("umbracoSitemapHide")]
		public bool UmbracoSitemapHide
		{
			get { return UmbracoSettings.GetUmbracoSitemapHide(this); }
		}

		///<summary>
		/// umbraco Url Alias
		///</summary>
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias
		{
			get { return UmbracoSettings.GetUmbracoUrlAlias(this); }
		}

		///<summary>
		/// umbraco Url Name
		///</summary>
		[ImplementPropertyType("umbracoUrlName")]
		public string UmbracoUrlName
		{
			get { return UmbracoSettings.GetUmbracoUrlName(this); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public object UmbracoFile
		{
			get { return this.GetPropertyValue("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
