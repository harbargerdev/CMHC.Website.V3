using System;
using System.Collections.Generic;
using System.Text;
using Amazon;
using Amazon.S3;

namespace CMHC.Website.Shared.ContentManager.Entities
{
    public class ContentUtility
    {
        private const string DEFAULT_REGION = "us-east-1";
        private const string SOURCE_BUCKET = "CMHC-ContentPages";
        private string IMG_URL_PREFIX = "http://cmhc-staff-pictures.s3-website-us-east-1.amazonaws.com/";
        private string STAFF_DB_CONN_STRING = "Data Source=chmc-staffdb.c5mxvqamkam3.us-east-1.rds.amazonaws.com,1433;Initial Catalog=StaffDb;User ID=cmhc_development;Password=AskMe2Care!";

        private AmazonS3Client _s3client;

        public ContentUtility()
        {
            _s3client = new AmazonS3Client(RegionEndpoint.USEast1);
        }

        #region Private Methods

        private string LoadStreamFromS3(string key)
        {


            return null;
        }
        
        #endregion
    }
}
