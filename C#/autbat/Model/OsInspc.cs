namespace autbat.Model
{
    public class OsModel
    {
        #region  Attribute

        public string OsName { get; set; }

        #endregion

        public OsModel()
        {
            OsName = System.Environment.OSVersion.VersionString;
        }
    }
}