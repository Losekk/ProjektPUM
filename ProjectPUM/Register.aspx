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
            
			<div class="modal-body" style="margin:30px 0px 0px 400px; top: -26px; left: -39px; width: 260px; height: 313px;">
              
                  <h3>Zarejestruj się</h3>
                      <div>
                          
                              <div class="form-group">
                                  <label for="login" class="control-label">Login</label>
          
                                  <asp:TextBox ID="txtLogin_register" class="form-control" placeholder="Login" runat="server"></asp:TextBox>
                                  
                                  
                                  <label for="password" class="control-label">Hasło</label>
          
                                  <asp:TextBox ID="txtPassword_register" class="form-control" placeholder="Hasło" TextMode="Password" runat="server"></asp:TextBox>
                                  
                                  
                             
                                  <label for="email" class="control-label">Email</label>
                                  <asp:TextBox ID="txtEmail_register" class="form-control" placeholder="Email"  runat="server"></asp:TextBox>
                                  
                                  
                              </div>

                        

                          <asp:Button ID="Register_bt" class="btn btn-success btn-block" runat="server" Text="Zarejestruj się" OnClick="Register_bt_Click"/>
                              
                             
                         
                      </div>
                  
                  
              
          </div>
            
            
            <div class="modal-body" style="margin:76px 0px 0px 30px; top: -445px; right: -652px; width: 260px; height: 313px;">
              
                <h3>&nbsp;</h3>
                <div>
                          
                    <div class="form-group">
                        <label for="firstname" class="control-label">Imię</label>
          
                        <asp:TextBox ID="txtFirstName_register" class="form-control" placeholder="Imię" runat="server"></asp:TextBox>
                                  
                                  
                        <label for="lastname" class="control-label">Nazwisko</label>
          
                        <asp:TextBox ID="txtLastName_register" class="form-control" placeholder="Login" runat="server"></asp:TextBox>
                                  
                                  
                             
                       
                                
                                  
                    </div>
                    <asp:CheckBox style="text-align: center; margin-top: 100px;" ID="MarketingAgreements" runat="server" Text="Zgadzam się na przetwarzanie danych osobowych w celach marketingowych"  />
                         
                        

                </div>
                  
                  
              
            </div>
      </div>
  </> 
          
    </form>

<script src="../js/jquery-3.1.1.min.js"></script>
<script src="../js/bootstrap.min.js"></script>
</html>
