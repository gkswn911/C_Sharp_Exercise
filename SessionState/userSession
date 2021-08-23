<script language="C#" runat="server" >
  private void Page_Load(object sender, EventArgs e)
  {
    string trialUsername = null;
    string trialPassword = null;
    
    this.authorizeStatus = false;
    
    // POST 방식으로 전달된 데이터에 있는지
    if (Request.Form["trialUsername"] != null)
    {
      if( Request.Form["trialPassword"] != null )
      {
        trialUsername = Request.Form["trialUsername"];
        trialPassword = Request.Form["trialPassword"];
        
        this.authorizeStatus = authorizeMembership
        (
          trialUsername,
          trialPassword
        );
      }
    }
    if (this.authorizeStatus)
    {
      Session["membershipUsername"] = trialUsername;
      
      Session["membershipPassword"] = trialPassword;
      
      Session.Timeout = 12 * 60;
    }
    
    return ;
  }
</script>
        
