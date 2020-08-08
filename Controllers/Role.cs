namespace WebApiEEP.Controllers
{
    public class Role
    {
        public int roleId {get; set;}
	    public string roleName {get; set;}
	    public string roleDescription {get; set;}

	    /// <summary>
         /// Constructor of the class Role
         /// </summary>
         /// <param name="roleId">Code of the role</param>
         /// <param name="roleName">Name of the role</param>
         /// <param name="roleDescription">Description of the role</param>
        public Role (int roleId, string roleName, string roleDescription) => 
            (this.roleId, this.roleName, this.roleDescription) = (roleId, roleName, roleDescription);
    }    
}