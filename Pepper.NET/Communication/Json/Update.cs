namespace Pepper.NET.Communication.Json
{
    public class Update
    {
        public int Type;
        public string UserId;
        public string AvatarCdnImageUrl;
        public string Name;
        public int Age;
        public int Gender;
        public int MatchPercentage;
        public bool MatchIsLiked;
        public string City;
        public int? AnswerId;
        public string QuestionText;
        public string AnswerText;
        public bool AnswerIsLiked;
        public string GalleryItemId;
        public string CdnImageUrl;
        public int? GalleryItemWidth;
        public int? GalleryItemHeight;
        public bool GalleryItemIsLiked;
        public string Timestamp;
        public bool IsUserOnline;
        public int MatchLikeStatus;
    }
}