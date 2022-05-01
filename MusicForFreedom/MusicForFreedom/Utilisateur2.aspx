<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Utilisateur.aspx.cs" Inherits="MusicForFreedom.Utilisateur1" %>

<!DOCTYPE html>
<html >
<head>

  <meta charset="UTF-8">

  <title>S'enregistrer/Se connecter</title>

  <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'>

  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">


  
      <link rel="stylesheet" href="Content/style.css">


  
</head>


<body>
  <div class="form">

      
      <ul class="tab-group">
        <li class="tab active"><a href="#signup">S'enregistrer</a></li>
        <li class="tab"><a href="#login">Connnection</a></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup">   
          <h1>Enregistrement gratuit</h1>
          
          <form action="/" method="post">
          
            <div class="field-wrap">
              <label>
                Pseudo<span class="req">*</span>
              </label>
              <input type="text" required autocomplete="off" />
            </div>



          <div class="field-wrap">
            <label>
              Adresse mail<span class="req">*</span>
            </label>
            <input type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Mot de passe<span class="req">*</span>
            </label>
            <input type="password"required autocomplete="off"/>
          </div>

          <div class="field-wrap">
            <label>
                Confirmation du mot de passe<span class="req">*</span>
            </label>
            <input type="password" required autocomplete="off" />
          </div>
          
          <button type="submit" class="button button-block"/>S'enregistrer</button>
              <br />
              <br />
          <p class="forgot"><a href="Accueil.aspx">RETOUR A LA PAGE D'ACCUEIL</a></p>

          </form>

        </div>
        
        <div id="login">   
          <h1>Welcome Back!</h1>
          
          <form action="/" method="post">
          
            <div class="field-wrap">
            <label>
              Adresse mail<span class="req">*</span>
            </label>
            <input type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Mot de passe<span class="req">*</span>
            </label>
            <input type="password"required autocomplete="off"/>
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
