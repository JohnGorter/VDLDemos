using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ClassLibrary1
{
    public class CustomRoleProvider : RoleProvider
    {
            public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void AddUsersToRoles(string[] usernames, string[] roleNames)
            {

            }

            public override void CreateRole(string roleName)
            {

            }

            public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
            {
                throw new NotImplementedException();
            }

            public override string[] FindUsersInRole(string roleName, string usernameToMatch)
            {
                throw new NotImplementedException();
            }

            public override string[] GetAllRoles()
            {
                throw new NotImplementedException();
            }

            public override string[] GetRolesForUser(string username)
            {
            return new string[] { "Administrators", "Users" };
            }

            public override string[] GetUsersInRole(string roleName)
            {
                return new String[] { "John", "Ed", "Roland" };
            }

            public override bool IsUserInRole(string username, string roleName)
            {
                throw new NotImplementedException();
            }

            public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
            {
                throw new NotImplementedException();
            }

            public override bool RoleExists(string roleName)
            {
                throw new NotImplementedException();
            }
    }
}
