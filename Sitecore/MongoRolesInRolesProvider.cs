using System;
using System.Collections.Generic;
using Sitecore.Security.Accounts;

namespace Sitecore.CustomMongoProviders
{
    public class MongoRolesInRolesProvider : RolesInRolesProvider
    {
        public override void AddRolesToRoles(IEnumerable<Role> memberRoles, IEnumerable<Role> targetRoles)
        {
            throw new NotImplementedException();
        }

        public override void RemoveRoleRelations(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveRolesFromRoles(IEnumerable<Role> memberRoles, IEnumerable<Role> targetRoles)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Role> FindRolesInRole(string targetRoleName, string roleNameToMatch)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Role> GetRolesForRole(string memberRoleName)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<Role> GetRolesInRole(string targetRoleName)
        {
            throw new NotImplementedException();
        }

        protected override bool IsRoleInRole(string memberRoleName, string targetRoleName)
        {
            throw new NotImplementedException();
        }
    }
}
