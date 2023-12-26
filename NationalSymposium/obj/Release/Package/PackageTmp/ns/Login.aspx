<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NSSWC.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../Styles/bootstrap.min.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.8.2/css/all.css" />
<link rel="stylesheet" href="../Styles/main.css"/>
<title>Jal Jeevan Mission</title>
    <style type="text/css">
        #Password1 {
            width: 180px;
        }
    </style>
    <script type="text/javascript">
        function showPass() {
            var cookies = document.cookie;
            var allcookies = cookies.split(";");
            for (ctr = 0; ctr < allcookies.length; ctr++) {
                var dt = allcookies[ctr];
                var str = dt.split("=");
                if (str[0].trim() == document.getElementById("Text_Username").value.trim()) {
                    document.getElementById("Text_Password").value = str[1];
                    break;
                }

            }
        }
        
            </script>

</head>
<body>
    <form id="form1" runat="server">
        <header class="header">
    <div class="container">
        <div class="row justify-content-center align-items-lg-center mobile--bg py-2 py-md-3">
            <div class="col-8 col-md-6 col-lg-5">
                <a href="index.html" class="logo"><img src="../images/logo.png" alt="logo"></a> 
            </div> 
            <div class="col-4 col-md-6 col-lg-7 text-end"> 
                <span><img src="../images/swachBharatlogo.png" alt="swachBharatlogo" class="swachBharatlogo"></span>
            </div>
        </div> 
    </div>
</header>
        <%--<div>
            
            <br />
            <br />
            
            <asp:Label ID="Label1" runat="server" Text="User Type"></asp:Label>
            
            
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
           
            
            <br />
            <br />
            <br />
            
            <br /> 
            
            <asp:Button ID="Btn_register" runat="server" Text="Register" OnClick="Btn_register_Click" Width="111px" Height="33px" style="margin-left: 69px" CausesValidation="false" />
            <asp:Button ID="Btn_forgetpassword" runat="server" Text="Forgot Password" OnClick="Btn_forgetpassword_Click" Height="34px" Width="124px" style="margin-left: 57px" CausesValidation="false" />
            <br />
            
        </div>--%>

        <div class="main-content">

    <section class="banner">
        <div class="row justify-content-center">
            <div class="col-12 col-md-12 col-lg-12 text-center">
                <h2>National Symposium on Safe Water &amp; Chlorination Initiatives</h2>
            </div>
            <div class="col-12 col-md-8 col-lg-6"> 
                <ul>
                    <li>
                        <span>Date: </span> <small>12/12/2023</small>
                    </li>
                    <li>
                        <span>Venue: </span> <strong>Auditorium, SPM Niwas, Kolkata</strong>
                    </li>
                    <li>
                        <span>Organised by:</span> Jal Jeevan Mission 
                    </li>
                    <li>
                        <span>Technical Partner: </span> Development Innovation Lab (DIL) and Evidence Action 
                    </li>
                </ul>
            </div>
        </div>
    </section>
    

    <section class="card-section">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-12 text-center"> 
                    <h4> Login Form </h4>
                    <h2>Welcome, User!</h2>
                </div>
                <div class="col-12 col-md-6 col-lg-6"> 
                    <div class="card-wrap">
                        <form>
                            <div class="input-container"> 
                                <i class="fa fa-user" aria-hidden="true"></i> 
                                <asp:TextBox ID="Text_Username" runat="server" class="form-control" placeholder="Email Id"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ErrorMessage="Please enter Email Id" ControlToValidate="Text_Username" CssClass="form-text"></asp:RequiredFieldValidator>
                               <%-- <input type="email" class="form-control" placeholder="Email Id">
                                <div id="emailHelp" class="form-text"></div>--%>
                            </div>
                            <div class="input-container">
                                <i class="fa fa-key" aria-hidden="true"></i> 
                                <asp:TextBox ID="Text_Password" TextMode="Password" placeholder="Password" onfocus="showPass()" runat="server" class="form-control"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ErrorMessage="Please enter Password" ControlToValidate="Text_Password" CssClass="form-text"></asp:RequiredFieldValidator>
                               <%-- <input type="password" class="form-control" placeholder="Password"> --%>
                            </div>
                            <div class="mb-3 form-check pl-0">
                                <asp:CheckBox ID ="rememberme" runat="server"  Text ="Remember Me" class="" />
                                <%--<input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                <label class="form-check-label" for="flexCheckDefault">
                                    Remember Me
                                </label>--%>
                            </div>
                            <div class="row mb-4">
                                <div class="col-12 col-sm-4 col-md-4"> 
                                    <a href="forgot_password.aspx" class="forgot-btn">Forgot password?</a>
                                </div>
                            
                                <div class="col-12 col-sm-4  col-md-8 remember-wrap"> 
                                    Don't have an account? <a href="Registration.aspx" class="remember-btn">Register</a>
                                </div>
                            </div>
                            <asp:Button ID="Btn_login" runat="server" Text="Login" OnClick="Btn_login_Click" class="btn btn-primary login-btn" />
                            <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
                            <%--<button type="submit" >Log In</button>--%>
                        </form>
                    </div>
                </div>  
            </div>
        </div>
    </section>

</div>

        <footer class="footer text-center">
   <div class="container">
       <div class="row">
           <div class="col-12">
               <p>
                   &copy; Copyrights 2023, Lead. All right are reserved.
               </p>
           </div> 
       </div>
   </div> 
</footer>
    </form>
    <script src="../Scripts/bootstrap.bundle.min.js"></script> 
</body>
</html>

<%--<script type="text/javascript">
    function validateLogin() {
        var username = document.getElementById('<%=TextBox1.ClientID%>').value;
        var password = document.getElementById('<%=TextBox2.ClientID%>').value;
        var Rememberme = document.getElementById('<%=rememberme.ClientID%>').checked;

        if (Rememberme) {
            // Save username and password in cookies
            document.cookie = "username=" + username + ";";
            document.cookie = "password=" + password + ";";
        } else {
            // Clear existing cookies
            document.cookie = "username=; expires=Monday, 01 Jan 2024 00:00:00 UTC; path=/;";
            document.cookie = "password=; expires=Monady, 01 Jan 2024 00:00:00 UTC; path=/;";
        }

        return true;
    }
</script>--%>
