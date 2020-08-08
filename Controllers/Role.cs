namespace WebApiEEP.Controllers
{
    public class Role
    {
        public int roleId {get; set;}
	    public string roleName {get; set;}
	    public string roleDescription {get; set;}

	    public Role (int roleId, string roleName, string roleDescription) => 
            (this.roleId, this.roleName, this.roleDescription) = (roleId, roleName, roleDescription);
    }    
}