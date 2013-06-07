using System;

using BetterCms.Core.Models;

namespace BetterCms.Module.MediaManager.Models.Maps
{
    [Serializable]
    public class MediaMap : EntityMapBase<Media>
    {
        public MediaMap()
            : base(MediaManagerModuleDescriptor.ModuleName)
        {
            Table("Medias");

            Map(x => x.Title).Length(MaxLength.Name).Not.Nullable();
            Map(x => x.Type).Not.Nullable();
            Map(x => x.ContentType).Not.Nullable();

            References(f => f.Folder).Cascade.SaveUpdate().LazyLoad().Nullable();
        }
    }
}