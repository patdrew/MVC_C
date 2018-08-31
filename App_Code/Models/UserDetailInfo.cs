using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDetails
/// </summary>
public class UserDetailInfo
{
    public  UserSpecific GetUserInformation(string dgk)
        {
            ElectronicaEntities db = new ElectronicaEntities();
            UserSpecific info = (from x in db.UserSpecifics
                        where x.DGK == dgk
                        select x).FirstOrDefault();
            return info;
        }

        public void ToInsertUserSpecifics(UserSpecific info)
        {
            ElectronicaEntities db = new ElectronicaEntities();
            db.UserSpecifics.Add(info);
            db.SaveChanges();
        }
      
	
    
}