﻿using ViLa.Model;
using WebExpress.WebCore.WebAttribute;
using WebExpress.WebCore.WebResource;

namespace ViLa.WebResource
{
    /// <summary>
    /// Lieferung einer im Assamby eingebetteten Ressource
    /// </summary>
    [Title("Measurements")]
    [Segment("measurements", "")]
    [ContextPath("/")]
    [IncludeSubPaths(true)]
    [Module<Module>]
    [Cache]
    public sealed class ResourceMeasurements : WebExpress.WebCore.WebResource.ResourceFile
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public ResourceMeasurements()
        {
            RootDirectory = ViewModel.Instance.Context.Host.AssetPath;
        }

        /// <summary>
        /// Initialisierung
        /// </summary>
        /// <param name="context">Der Kontext</param>
        public override void Initialization(IResourceContext context)
        {
            base.Initialization(context);
        }
    }
}