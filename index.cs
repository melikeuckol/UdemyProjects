<html>
<head>
    <style>
        .header{
            background-color:#1abc9c;
            color:white;
            padding:60px;
            text-align:center;
        }
        .navbar{
            display:flex;
            background-color:#333;
        }
        .navbar a{
            padding:8px 20px;
            text-decoration:none;
            color:white;
           
        }
        .navbar a:hover{
            color:black;
            background-color:#ddd;
        }
        .row{
            display:flex;
        }
        .side{
            flex:30%;
            background-color:#f1f1f1;
            padding:20px;
        }
        .fakeimg{
            background-color:#aaa;
            padding:20px;
        }
        .main{
            flex:70%;
            padding:20px;
        }
        .footer{
            text-align:center;
            padding:20px;
            background-color:#ddd;
        }
        @@media screen and (max-width:700px)
        {
            .row,.navbar{
                flex-direction:column;
            }
        }
        </style>
  
</head>
<body>

    <div style="background-color:yellow;padding:5px">
        <h4 style="text-align:center">Resize the browser to see the responsive effect.</h4>
    </div>

    <div class="header">
        <h1>My Website</h1>
        <p>With a <b>flexible</b> layout.</p>
    </div>

    <div class="navbar">
        <a href="#">Link</a>
        <a href="#">Link</a>
        <a href="#">Link</a>
        <a href="#">Link</a>
    </div>

    <div class="row">
        <div class="side">
            <h2>About Me</h2>
            <h5>Photo of me</h5>
            <div class="fakeimg" style="height:200px">Image</div>
            <p>Some text about me in culpa qui officia desurunt mollit anim..</p>
            <h3>More Text..</h3>
            <p>Lorem ipsum doler sit ame..</p>
            <div class="fakeimg" style="height:60px">Image</div>
            <div class="fakeimg" style="height:60px">Image</div>
            <div class="fakeimg" style="height:60px">Image</div>
        </div>

        <div class="main">
            <h2>TITLE HEADING</h2>
            <h5>Tıtle description,December,5,2023</h5>
            <div class="fakeimg" style="height:200px">Image</div>
            <p>Some Text..</p>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
            <br />
            <h2>TITLE HEADING</h2>
            <h5>Tıtle description,December,5,2023</h5>
            <div class="fakeimg" style="height:200px">Image</div>
            <p>Some Text..</p>
            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
        </div>

    </div>
    <div class="footer">
        <h2>Footer</h2>
    </div>
   
</body>
</html>
