<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="NationalSymposium.ns.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../Styles/bootstrap.min.css"/>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.8.2/css/all.css" />
<link rel="stylesheet" href="../Styles/main.css"/>
<title>Jal Jeevan Mission</title>
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
                    <h4> Registraion Form </h4>
                    <h2>Welcome, User!</h2>
                </div>
                <div class="col-12 col-md-6 col-lg-6"> 
                    <div class="card-wrap">
                        <form>
                            <div class="row">
                                <div class="col offset-md-2 col-md-8 offset-sm-2 col-sm-8">
                                            <asp:RadioButtonList ID="radioButtonList" runat="server" >
    <asp:ListItem Text="Participant" Value="1" />
    <asp:ListItem Text="Speech Maker" Value="0" />
</asp:RadioButtonList>
                                   <%-- <div class="form-check">
                                        <input class="form-check-input" type="radio" name="radioDefault" id="radioDefault1" checked>
                                        <label class="form-check-label" for="radioDefault1">
                                            PARTICIPANTS
                                        </label>
                                      </div>--%>
                                    </div>
                                   <%-- <div class="col col-md-4">
                                      <div class="form-check">
                                        <input class="form-check-input" type="radio" name="radioDefault" id="radioDefault2" >
                                        <label class="form-check-label" for="radioDefault2">
                                            PRESENTER
                                        </label>
                                      </div>
                                </div> --%>
                            </div>

                            <div class="row">
                                <div class="col col-md-12">
                                    <div class="input-container"> 
                                        <i class="fa fa-compass" aria-hidden="true"></i> 
                                         <asp:DropDownList ID="ddlCategories" runat="server" CssClass="form-select">
     <asp:ListItem Text="Select State" Value="" />
 </asp:DropDownList>
                                        <%--<select class="form-select" >
                                            <option selected>Select State Name</option>
                                            <option value="1">Lorem1</option>
                                            <option value="2">Lorem2</option>
                                            <option value="3">Lorem3</option>
                                        </select>--%>
                                    </div>
                                </div>
                            </div>


                            <div class="row">
                                <div class="col col-md-6">
                                    <div class="input-container "> 
                                        <i class="fa fa-user" aria-hidden="true"></i>
                                                <asp:TextBox ID="txtName" runat="server"  class="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ControlToValidate="txtName" class="form-text" runat="server" Text="Please enter Name"></asp:RequiredFieldValidator>
                                       <%-- <input type="text" class="form-control" placeholder="Enter Full Name">
                                        <div id="nameHelp" class="form-text"></div>--%>
                                    </div>
                                </div>
                                <div class="col col-md-6">
                                    <div class="input-container"> 
                                        <i class="fa fa-envelope" aria-hidden="true"></i>
                                        <asp:TextBox ID="txtemail" class="form-control" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ControlToValidate ="txtemail" runat="server" class="form-text" Text="Please enter Email"></asp:RequiredFieldValidator>
                                       <%-- <input type="email" class="form-control" placeholder="Email Id">
                                        <div id="emailHelp" class="form-text"></div>--%>
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col col-md-6">
                                    <div class="input-container"> 
                                        <i class="fa fa-key" aria-hidden="true"></i>

                                        <%--<input type="password" class="form-control" placeholder="Enter Password"> --%>
                                        <asp:TextBox ID="txtpassword" runat="server" EnableTheming="False" TextMode="Password" class="form-control"></asp:TextBox>
 <asp:RequiredFieldValidator ControlToValidate="txtpassword" runat="server" class="form-text"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col col-md-6">
                                    <div class="input-container"> 
                                        <i class="fa fa-briefcase" aria-hidden="true"></i>
                                        <asp:DropDownList ID="ddlCategories1" runat="server"  class="form-select">
    <asp:ListItem Text="Select Designation" Value="" />
</asp:DropDownList>
<%--                                        <select class="form-select" >
                                            <option selected>Select Designation</option>
                                            <option value="1">Lorem1</option>
                                            <option value="2">Lorem2</option>
                                            <option value="3">Lorem3</option>
                                          </select>--%>
                                          
                                    </div>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col col-md-6">
                                    <div class="input-container"> 
                                        <i class="fa fa-mobile" aria-hidden="true"></i>

                                        <%--<input type="text" class="form-control" placeholder="Enter Mobile"> --%>
                                        <asp:TextBox ID="txtMobile" runat="server" class="form-control"></asp:TextBox>
<asp:RequiredFieldValidator ControlToValidate ="txtMobile" runat="server" Text="Please enter Mobile Number" class="form-text"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col col-md-6">
                                    <div class="input-container"> 
                                        <i class="fa fa-sitemap" aria-hidden="true"></i>
                                                    <asp:DropDownList ID="ddlCategories2" runat="server"  class="form-select">
                <asp:ListItem Text="Select Organization" Value="" />
            </asp:DropDownList>
                                       <%-- <select class="form-select" >
                                            <option selected>Select Organisation</option>
                                            <option value="1">Lorem1</option>
                                            <option value="2">Lorem2</option>
                                            <option value="3">Lorem3</option>
                                          </select> --%>
                                    </div>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col col-md-12"> 
                                    <div class="remember-wrap text-center"> 
                                        Already have account?  <a href="Login.aspx" class="remember-btn">Login</a>
                                    </div> 
                                    
                                    <div class="text-center"> 
                                        <div class="mb-2 form-check" style="display: inline-block;">
                                            <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                            <label class="form-check-label" for="flexCheckDefault">
                                                I agree with terms and conditions
                                            </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
<asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary common-btn"  OnCommand="Submit_Click"/>
                       
                           <%-- <button type="submit" class="btn btn-primary common-btn">Register</button>--%>
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
