function NavBarAdminPage()
{
    let navBar = document.querySelectorAll('div [class="navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"]');

    //TO DO if login remove Login and Registration elements
    let nodeAWelcomeMsg = document.createElement('A');
    nodeAWelcomeMsg.textContent=`Welcome to Admin page`;
    navBar[0].parentNode.appendChild(nodeAWelcomeMsg);
}

NavBarAdminPage();