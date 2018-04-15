<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectPUM.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <title>Zarejestruj się</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/Style.css" rel="stylesheet" />
</head>
<body style="background-image:url('Images/background.png')">
    <form id="form1" runat="server">
        <div class="panel-img">
            <img src="Images/Panel.png" />
           </div>
        <div>
            
			<div style="position: absolute; z-index: 1" id="layer2" ><div class="modal-body" style="margin:30px 0px 0px 400px; top: 0px; left: 0px; width: 252px;">
              
                  <h3>Zarejestruj się</h3>
                      <div>
                          
                              <div class="form-group">
                                  <label for="username" class="control-label">Login</label>
                                  <asp:TextBox ID="txtuser_rg" class="form-control" placeholder="Login" runat="server"></asp:TextBox>
                                  
                                  <span class="help-block"></span>
                              </div>
                              <div class="form-group">
                                  <label for="password" class="control-label">Hasło</label>
                                  <asp:TextBox ID="txtpass_rg" class="form-control" placeholder="Hasło" TextMode="Password" runat="server"></asp:TextBox>
                                  
                                  <span class="help-block"></span>
                              </div>
                        

                          <asp:Button ID="Register_bt" class="btn btn-success btn-block" runat="server" Text="Zarejestruj się" OnClick="Register_bt_Click"/>
                              
                             
                         
                      </div>
                  
                  
              
          </div>
      </div>
  </div> 

    </form>

<script src="js/jquery-3.1.1.min.js"></script>
<script src="js/bootstrap.min.js"></script>
</html>
