//namespace ExamensArbete
//{
//    public static class CheckImageContent
//    {
//        public const int ImageMinimumBytes = 512;

//        public static bool IsImage(this IFormFile postedFile)
//        {
//            //-------------------------------------------
//            //  Check the image mime types
//            //-------------------------------------------
//            if (postedFile.ContentType.ToLower() != "image/jpg" &&
//                               postedFile.ContentType.ToLower() != "image/jpeg" &&
//                                              postedFile.ContentType.ToLower() != "image/pjpeg" &&
//                                                             postedFile.ContentType.ToLower() != "image/gif" &&
//                                                                            postedFile.ContentType.ToLower() != "image/x-png" &&
//                                                                                           postedFile.ContentType.ToLower() != "image/png")
//            {
//                return false;
//            }

//            //-------------------------------------------
//            //  Check the image extension
//            //-------------------------------------------
//            var postedFileExtension = Path.GetExtension(postedFile.FileName);
//            if (postedFileExtension.ToLower() != ".jpg"
//                               && postedFileExtension.ToLower() != ".png"
//                                              && postedFileExtension.ToLower() != ".gif"
//                                                             && postedFileExtension.ToLower() != ".jpeg")
//            {
//                return false;
//            }


//            return true;
//        }
//    }
//}




namespace ExamensArbete
{
    public static class CheckImageContent
    {
        public const int ImageMinimumBytes = 512;

        private static readonly string[] AllowedContentTypes = { "image/jpg", "image/jpeg", "image/pjpeg", "image/gif", "image/x-png", "image/png" };

        public static bool IsImage(this IFormFile postedFile)
        {
            // Check the image mime types
            if (!AllowedContentTypes.Contains(postedFile.ContentType.ToLower()))
            {
                return false;
            }

            // Check the image extension
            var postedFileExtension = Path.GetExtension(postedFile.FileName).ToLower();
            if (!(postedFileExtension == ".jpg" || postedFileExtension == ".png" || postedFileExtension == ".gif" || postedFileExtension == ".jpeg"))
            {
                return false;
            }

            return true;
        }
    }
}





