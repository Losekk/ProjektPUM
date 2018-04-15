<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectPUM.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Zaloguj się</title>
    <link href="Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Bootstrap/Style.css" rel="stylesheet" />
</head>
<body style="background-image:url('Images/background.png')">
    <form id="form1" runat="server">
        <div class="panel-img">
            <img src="Images/Panel.png" />
           </div>
        <div>
			<div style="position: absolute; z-index: 1" id="layer2" ><div class="modal-body" style="margin:30px 0px 0px 400px">
              <div class="row">
                  <div class="col-xs-6">
                      <div>
                          
                              <div class="form-group">
                                  <label for="username" class="control-label">Login</label>
                                  <asp:TextBox ID="txtuser" class="form-control" placeholder="Login" runat="server"></asp:TextBox>
                                  
                                  <span class="help-block"></span>
                              </div>
                              <div class="form-group">
                                  <label for="password" class="control-label">Hasło</label>
                                  <asp:TextBox ID="txtpass" class="form-control" placeholder="Hasło" TextMode="Password" runat="server"></asp:TextBox>
                                  
                                  <span class="help-block"></span>
                              </div>
                        

                          <asp:Button ID="Login_bt" class="btn btn-success btn-block" runat="server" Text="Zaloguj się" OnClick="Login_bt_Click"/>
                              
                              <a href="/forgot/" class="btn btn-default btn-block">Przypomnij hasło</a>
                         
                      </div>
                  </div>
                  <div class="col-xs-6">
                      
                      <p><a href="/new-customer/" class="btn btn-info btn-block">Zarejestruj się</a></p>
                  </div>
              </div>
          </div>
      </div>
  </div> 

    </form>

<script src="js/jquery-3.1.1.min.js"></script>
<script src="js/bootstrap.min.js"></script>
</body>
</html>
