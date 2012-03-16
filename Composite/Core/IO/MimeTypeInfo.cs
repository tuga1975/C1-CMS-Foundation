﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Web.Configuration;
using System.Web.Hosting;
using System.Xml.Linq;
using Composite.C1Console.Forms.CoreUiControls;
using Composite.Core.Extensions;
using Composite.Core.ResourceSystem;
using Composite.Core.ResourceSystem.Icons;


namespace Composite.Core.IO
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
	public static class MimeTypeInfo
    {
        private static readonly string LogTitle = typeof (MimeTypeInfo).Name;

        private static readonly IDictionary<string, string> _toCanonical = new Dictionary<string, string>();
        private static readonly IDictionary<string, string> _extensionToCanonical = new Dictionary<string, string>();
        private static readonly IDictionary<string, string> _mimeTypeToResourceName = new Dictionary<string, string>();

        private static readonly MethodInfo _getMimeMappingMethodInfo = typeof(System.Web.HttpUtility).Assembly
            .GetType("System.Web.MimeMapping").GetMethod("GetMimeMapping", BindingFlags.Static | BindingFlags.NonPublic);

        private static ResourceHandle GetIconHandle(string name)
        {
            return new ResourceHandle(BuildInIconProviderName.ProviderName, name);
        }

        /// <exclude />
        public static string Jpeg
        {
            get { return "image/jpeg";}
        }

        /// <exclude />
        public static string Default
        {
            get { return "application/octet-stream"; }
        }

        /// <exclude />
        public static string Gif
        {
            get { return "image/gif"; }
        }

        /// <exclude />
        public static string Bmp
        {
            get { return "image/bmp"; }
        }

        /// <exclude />
        public static string Png
        {
            get { return "image/png"; }
        }

        /// <exclude />
        public static string Tiff
        {
            get { return "image/tiff"; }
        }

        /// <exclude />
        public static string Css
        {
            get { return "text/css"; }
        }

        /// <exclude />
        public static string Js
        {
            get { return "text/js"; }
        }

        /// <exclude />
        public static string Xml
        {
            get { return "text/xml"; }
        }

        /// <exclude />
        public static string Text
        {
            get { return "text/plain"; }
        }

        /// <exclude />
        public static string Html
        {
            get { return "text/html"; }
        }

        /// <exclude />
        public static string Flash
        {
            get { return "application/x-shockwave-flash"; }
        }

        /// <exclude />
        public static string QuickTime
        {
            get { return "video/quicktime"; }
        }

        /// <exclude />
        public static string Wmv
        {
            get { return "video/x-ms-wmv"; }
        }

        /// <exclude />
        public static string Asf
        {
            get { return "video/x-ms-asf"; }
        }

        /// <exclude />
        public static string Avi
        {
            get { return "video/x-msvideo"; }
        }

        /// <exclude />
        public static string Flv
        {
            get { return "video/x-flv"; }
        }

        /// <exclude />
        public static string Director
        {
            get { return "application/x-director"; }
        }

        /// <exclude />
        public static string CSharp
        {
            get { return "text/x-csharp"; }
        }

        /// <exclude />
        public static string CsHtml
        {
            get { return "application/x-cshtml"; }
        }

        /// <exclude />
        public static string Ascx
        {
            get { return "application/x-ascx"; }
        }

        /// <exclude />
        public static string Aspx
        {
            get { return "application/x-aspx"; }
        }

        /// <exclude />
        public static string Ashx
        {
            get { return "application/x-ashx"; }
        }

        /// <exclude />
        public static string Resx
        {
            get { return "application/x-resx"; }
        }

        /// <exclude />
        public static string MasterPage
        {
            get { return "application/x-master-page"; }
        }


        /// <exclude />
        static MimeTypeInfo()
        {
            LoadExtensionMappingsFromWebConfig();

            // Image formats
            _toCanonical.Add("image/pjpg", Jpeg);
            _toCanonical.Add("image/pjpeg", Jpeg);
            _toCanonical.Add("image/jpg", Jpeg);
            RegisterMimeType(MimeTypeInfo.Jpeg, new [] {"jpg", "jpe", "jpeg"}, "mimetype-jpeg");

            RegisterMimeType(MimeTypeInfo.Gif, "gif", "mimetype-gif");
            RegisterMimeType(MimeTypeInfo.Bmp, "bmp", "mimetype-bmp");

            _toCanonical.Add("image/x-png", Png);
            RegisterMimeType(MimeTypeInfo.Png, "png", "mimetype-png");

            _toCanonical.Add("image/tif", MimeTypeInfo.Tiff);
            RegisterMimeType(MimeTypeInfo.Tiff, "tif", "mimetype-tiff");

            // Web
            RegisterMimeType(MimeTypeInfo.Css, new [] {"css", "less"}, "mimetype-css");
            RegisterMimeType(MimeTypeInfo.Resx, "resx", "mimetype-resx");

            _toCanonical.Add("application/x-javascript", MimeTypeInfo.Js);
            RegisterMimeType(MimeTypeInfo.Js, "js", "mimetype-js");

            RegisterMimeType("text/html", new[] { "htm", "html", "xhtml" }, "mimetype-html");

            // Audio/Video
            RegisterMimeType("audio/x-wav", "wav", null /* "mimetype-vaw" */);
            RegisterMimeType("audio/x-pn-realaudio", new[] { "ram", "rm" }, "mimetype-ram");
            RegisterMimeType("audio/mpeg", "mp3", "mimetype-mp3");
            RegisterMimeType("video/mpeg", new[] { "mpeg", "mpg" }, "mimetype-mpeg");
            RegisterMimeType(MimeTypeInfo.Flv, "flv");
            RegisterMimeType(MimeTypeInfo.Asf, "asf", "mimetype-asf");
            RegisterMimeType(MimeTypeInfo.Avi, "avi", "mimetype-movie");
            RegisterMimeType(MimeTypeInfo.Wmv, "wmv", "mimetype-wmv");

            // Applications
            RegisterMimeType("application/postscript", "eps", "mimetype-pps");
            RegisterMimeType("application/msaccess", "mdb", "mimetype-mdb");
            RegisterMimeType("application/pdf", "pdf", "mimetype-pdf");
            RegisterMimeType("application/vnd.ms-powerpoint", "ppt", "mimetype-ppt");
            RegisterMimeType("application/vnd.openxmlformats-officedocument.presentationml.presentation", "pptx", "mimetype-ppt");
            RegisterMimeType("application/msword", "doc", "mimetype-doc");
            RegisterMimeType("application/vnd.openxmlformats-officedocument.wordprocessingml.document", "docx", "mimetype-doc");
            RegisterMimeType("application/rtf", "rtf", "mimetype-rtf");
            RegisterMimeType("application/vnd.visio", "vsd", "mimetype-vsd");
            RegisterMimeType("application/x-font-woff", "woff");
            RegisterMimeType("application/vnd.ms-excel", "xls", "mimetype-xls");
            RegisterMimeType("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "xlsx", "mimetype-xls");

            RegisterMimeType(MimeTypeInfo.QuickTime, "mov", "mimetype-mov");
            RegisterMimeType(MimeTypeInfo.Flash, "swf", "mimetype-swf");
            RegisterMimeType(MimeTypeInfo.Director, new[] { "dcr", "dir" }, "mimetype-dir");

            RegisterMimeType("text/xml", new[] { "xml", "config", "xsl", "xslt" }, "mimetype-xml");

            const string mimeTypeZip = "application/zip";
            _toCanonical.Add("application/x-zip-compressed", mimeTypeZip);
            RegisterMimeType(mimeTypeZip, "zip", "mimetype-zip");

            
            _toCanonical.Add("text/txt", "text/plain");
            _toCanonical.Add("text/text", "text/plain");
            RegisterMimeType("text/plain", "txt", "mimetype-txt");


            // .Cs and asp.net files
            RegisterMimeType(MimeTypeInfo.Ascx, "ascx", "mimetype-ascx");
            RegisterMimeType(MimeTypeInfo.Aspx, "aspx", "mimetype-aspx");
            RegisterMimeType(MimeTypeInfo.Ashx, "ashx");
            RegisterMimeType(MimeTypeInfo.MasterPage, "master");

            RegisterMimeType(MimeTypeInfo.CSharp, "cs");
            RegisterMimeType(MimeTypeInfo.CsHtml, "cshtml", "mimetype-cshtml");

            
            
            AddExtensionMapping("mp4", "video/mp4");
            AddExtensionMapping("ogg", "audio/ogg");
            AddExtensionMapping("ogv", "video/ogg");
            AddExtensionMapping("webm", "video/webm");
            AddExtensionMapping("svg", "image/svg+xml");
            AddExtensionMapping("svgz", "mage/svg+xml");
            AddExtensionMapping("flv4", "video/mp4");
            AddExtensionMapping("eot", "application/vnd.ms-fontobject");
        }

        private static void RegisterMimeType(string canonicalMimeTypeName, string extension, string resourceName = null)
        {
            RegisterMimeType(canonicalMimeTypeName, new [] { extension }, resourceName);
        }

        private static void RegisterMimeType(string canonicalMimeTypeName, string[] extensions, string resourceName)
        {
            _toCanonical.Add(canonicalMimeTypeName, canonicalMimeTypeName);

            foreach(string extension in extensions)
            {
                AddExtensionMapping(extension, canonicalMimeTypeName);
            }

            if(resourceName != null)
            {
                _mimeTypeToResourceName.Add(canonicalMimeTypeName, resourceName);
            }
        }

        private static bool AddExtensionMapping(string extension, string mimeType)
        {
            if(!_extensionToCanonical.ContainsKey(extension))
            {
                _extensionToCanonical.Add(extension, mimeType);
                return true;
            }

            return false;
        }

        private static void LoadExtensionMappingsFromWebConfig()
	    {
            ConfigurationSection config;
            try
            {
                config = WebConfigurationManager.OpenWebConfiguration(HostingEnvironment.ApplicationVirtualPath).GetSection("system.webServer");
            }
            catch
	        {
                // Silent
                return;
	        }

            if(config == null)
            {
                return;
            }

            XElement webServerConfig = XElement.Parse(config.SectionInformation.GetRawXml());
            XElement staticContentConfig = webServerConfig.Element("staticContent");
            if(staticContentConfig == null)
            {
                return;
            }

            foreach(XElement mimeMapping in staticContentConfig.Elements("mimeMap"))
            {
                string extension = mimeMapping.Attribute("fileExtension").Value.ToLowerInvariant();
                string mimeType = mimeMapping.Attribute("mimeType").Value;

                if(extension.StartsWith("."))
                {
                    extension = extension.Substring(1);
                }

                if (!AddExtensionMapping(extension, mimeType))
                {
                    Log.LogWarning(typeof(MimeTypeInfo).Name, "MimeType for extension '{0}' has already been defined", extension);
                }
            }
	    }

        /// <exclude />
        public static string GetCanonical(string mimeType)
        {
            if (string.IsNullOrEmpty(mimeType))
            {
                return MimeTypeInfo.Default;
            }

            mimeType = mimeType.ToLowerInvariant();

            if (_toCanonical.ContainsKey(mimeType))
            {
                return _toCanonical[mimeType];
            }

            return mimeType;
        }



        /// <exclude />
        public static ResourceHandle GetResourceHandleFromMimeType(string mimeType)
        {
            if (mimeType == null)
            {
                return GetIconHandle("mimetype-unknown");
            }

            if (_mimeTypeToResourceName.ContainsKey(mimeType))
            {
                return GetIconHandle(_mimeTypeToResourceName[mimeType]);
            }
            return GetIconHandle("mimetype-unknown");
        }



        /// <exclude />
        public static string GetCanonicalFromExtension(string extension)
        {
            if (extension == null)
            {
                return MimeTypeInfo.Default;
            }

            extension = extension.ToLowerInvariant();

            if (extension.StartsWith("."))
            {
                extension = extension.Substring(1);
            }

            if (_extensionToCanonical.ContainsKey(extension.ToLowerInvariant()))
            {
                return _extensionToCanonical[extension];
            }

            string fileName = "filename." + extension;
            return _getMimeMappingMethodInfo.Invoke(null, new object[] { fileName }) as string;
        }

        /// <exclude />
        public static string GetMimeType(UploadedFile uploadedFile)
        {
            string fileName = System.IO.Path.GetFileName(uploadedFile.FileName);

            string mimeTypeFromExtension = MimeTypeInfo.GetCanonicalFromExtension(System.IO.Path.GetExtension(fileName));
            if (mimeTypeFromExtension != MimeTypeInfo.Default)
            {
                Log.LogInformation(LogTitle, "Uploading file '{0}'. MIME type from extention: '{1}'"
                                                .FormatWith(fileName, mimeTypeFromExtension));

                return mimeTypeFromExtension;
            }
            
            string mimeTypeFromBrowser = MimeTypeInfo.GetCanonical(uploadedFile.ContentType);

            // Default MIME type for Chrome is "application/xml"
            // Default MIME type for IE is "text/plain"
            // for the rest it is "application/octet-stream"
            if (mimeTypeFromBrowser != "application/xml"
                && mimeTypeFromBrowser != "text/plain")
            {
                Log.LogInformation(LogTitle, "Uploading file '{0}'. Browser provided MIME type: '{1}'. Canonical MIME type: '{2}'"
                                        .FormatWith(fileName, uploadedFile.ContentType ?? string.Empty, mimeTypeFromBrowser));
                

                return mimeTypeFromBrowser;
            }
            
            Log.LogInformation(LogTitle, "Uploading file '{0}'. Applying default MIME type '{1}'"
                                            .FormatWith(fileName, MimeTypeInfo.Default));

            return MimeTypeInfo.Default;
        }
	}
}
