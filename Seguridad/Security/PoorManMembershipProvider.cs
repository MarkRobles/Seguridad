using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Seguridad.Security
{
    public class PoorManMembershipProvider : MembershipProvider
    {
        public override bool ValidateUser(String username, String password)
        {
            // Validate user name
      
          
// Runs a query against the data store to retrieve the
// password for the specified user. We're assuming that the
// retrieved password is hashed.
//var storedPassword = GetStoredPasswordForUser(username);
            // No user found
          //  if (storedPassword == null)
                return false;
            // Hash the provided password and see if that matches the stored password
           // var hashedPassword = Utils.HashPassword(password);
          //  return hashedPassword == storedPassword;
        }
        public override MembershipUser GetUser(String username, Boolean userIsOnline)
        {
     //
       
}
        public override MembershipUser CreateUser(String username, String password,
String email, String passwordQuestion, String passwordAnswer,
Boolean isApproved, Object providerUserKey,
out MembershipCreateStatus status)
        {
         
}
        public override Boolean ChangePassword(String username, String oldPassword, String
        newPassword)
        {
            
}
// Remainder of the MembershipProvider interface

}
}