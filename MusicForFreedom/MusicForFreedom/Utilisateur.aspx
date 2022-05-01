<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Utilisateur.aspx.cs" Inherits="MusicForFreedom.Utilisateur1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>


  <title>S'enregistrer/Se connecter</title>

  <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'/>

  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css"/>


  
      <link rel="stylesheet" href="Content/style.css"/>


  
</head>


<body>
  <div class="form">

   <form runat="server">    
      <ul class="tab-group">
        <li class="tab active"><a href="#signup">S'enregistrer</a></li>
        <li class="tab"><a href="#login" onclick="">Connnection</a></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup">   
          <h1>Enregistrement gratuit</h1>
          
           

                <div class="field-wrap">
                    <label>
                        Pseudo<span class="req">*</span>
                    </label>
                    <asp:TextBox ID="tbPseudo" runat="server" required="true" autocomplete="off"></asp:TextBox>
                </div>



                <div class="field-wrap">
                    <label>
                        Adresse mail<span class="req">*</span>
                    </label>
                    <asp:TextBox ID="tbMail" runat="server" type="email" required="true" autocomplete="off"></asp:TextBox>
                </div>

                <div class="field-wrap">
                    <label>
                        Mot de passe<span class="req">*</span>
                    </label>
                    <asp:TextBox ID="tbMotdePasse" runat="server" type="password" required="true" autocomplete="off"></asp:TextBox>
                </div>

                <div class="field-wrap">
                    <label>
                        Confirmation du mot de passe<span class="req">*</span>
                    </label>
                    <asp:TextBox ID="tbMotdePasseConfirm" runat="server" type="password" required="true" autocomplete="off"></asp:TextBox>
                </div>
                <asp:Button ID="BtnEnregistrer" runat="server" Text="S'enregistrer" class="button button-block" OnClick="BtnEnregistrer_Click" />
                <br />
                <br />
                <p class="forgot"><a href="Accueil.aspx">RETOUR A LA PAGE D'ACCUEIL</a></p>

            </form>

        </div>
        
        <div id="login">   
          <h1>Welcome Back!</h1>
          
          <form action="Home.aspx" method="get">
          
            <div class="field-wrap">
            <label>
              Adresse mail<span class="req">*</span>
            </label>
            <input type="email"required name="email" autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Mot de passe<span class="req">*</span>
            </label>
            <input type="password"required name="password" autocomplete="off"/>
          </div>
          
          <p class="forgot"><a href="#">Mot de passe oublié?</a></p>
          
          <button class="button button-block"/>Se connecter</button>

              <br />
              <br />
          <p class="forgot"><a href="Accueil.aspx">RETOUR A LA PAGE D'ACCUEIL</a></p>

          
          </form>

        </div>
        
      </div><!-- tab-content -->
      
</div> <!-- /form -->
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script src="Scripts/scripts/index.js"></script>

</body>
</html>
