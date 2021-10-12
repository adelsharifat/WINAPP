using CMISUtils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMISBEL.Core.Common
{
    public class belUser
    {
        public Image FetchAvatarByUserId(int userId)
        {
            try
            {
                var avatarByteArray = CMISDAL.Common.CommonDals.User.FetchAvatarByUserId(userId);
                if (avatarByteArray == null) return null;

                var imageAvatar = CMISUtils.Utilities.ToImage(avatarByteArray);
                return imageAvatar.ResizeImage(256, 256);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
