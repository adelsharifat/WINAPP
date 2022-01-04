using CMISUtils;
using DMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS.Extentions
{
    public static class MapTvpAttachment
    {
        public static DataTable MapToTvpAttachment(this List<FileAttachmentViewModel> list)
        {
            return list.Select(x => new DbFileAttachment
            {
                Id = x.Id,
                stream_id = x.stream_id,
                FileStream = x.FileStream,
                FileName = x.FileName,
                Remark = x.Remark,
                Type = x.Type,
                CustomType = x.CustomType
            }).ToDataTable<DbFileAttachment>();
        }
    }
}
