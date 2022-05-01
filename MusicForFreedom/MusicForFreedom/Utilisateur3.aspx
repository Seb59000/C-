<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Utilisateur3.aspx.cs" Inherits="MusicForFreedom.UserFormsTest" %>

<!DOCTYPE html>
<html >
<head>

  <meta charset="UTF-8">

  <title>Sign-Up/Login Form</title>



  
      <link rel="stylesheet" href="Content/style.css">


  
</head>


<body>
  <div class="form">

      
      <ul class="tab-group">
        <li class="tab active"><a href="#signup">Sign Up</a></li>
        <li class="tab"><a href="#login">Log In</a></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup">   
          <h1>Sign Up for Free</h1>
          
          <form action="Utilisateur2.aspx" method="post" runat="server" >
          
          <div class="top-row">
            <div class="field-wrap">
              <label>
                First Name<span class="req">*</span>
              </label>
              <asp:TextBox ID="Name" runat="server" required="true" autocomplete="off"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ControlToValidate="Name" runat="server" ></asp:RequiredFieldValidator>--%>
            </div>
        
            <div class="field-wrap">
              <label>
                Last Name<span class="req">*</span>
              </label>
                            <asp:TextBox ID="TextBox1" runat="server" required="true" type="email" autocomplete="off"></asp:TextBox>

            </div>
          </div>

          <div class="field-wrap">
            <label>
              Email Address<span class="req">*</span>
            </label>
            <input type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Set A Password<span class="req">*</span>
            </label>
            <input type="password"required autocomplete="off"/>
          </div>
          
          <button type="submit" class="button button-block" onclick="ButtonClick"/>Get Started</button>
          
          </form>

        </div>
        
        <div id="login">   
          <h1>Welcome Back!</h1>
          
          <form action="/" method="post">
          
            <div class="field-wrap">
            <label>
              Email Address<span class="req">*</span>
            </label>
            <input type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Password<span class="req">*</span>
            </label>
            <input type="password"required autocomplete="off"/>
          </div>
          
          <p class="forgot"><a href="#">Forgot Password?</a></p>
          
          <button class="button button-block"/>Log In</button>
          
          </form>

        </div>
        
      </div><!-- tab-content -->
      
</div> <!-- /form -->

    <script src="Scripts/scripts/index.js"></script>

</body>
</html>

