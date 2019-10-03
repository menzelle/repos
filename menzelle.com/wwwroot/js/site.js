/* Set the width of the sidebar to 250px and the left margin of the page content to 250px */
function openNav() {
    document.getElementById("mySidebar").style.width = "250px";
}

/* Set the width of the sidebar to 0 and the left margin of the page content to 0 */
function closeNav() {
    document.getElementById("mySidebar").style.width = "0";
}


    function getContent(projectinfo) {
        var content = document.getElementById(projectinfo).innerHTML;
        setTitle(projectinfo);
         setContent(content);
}
//---------->get content from hidden p tag
    function setContent(content) {
        document.getElementById("projectinfo").innerHTML = content;
    $("#menzellesModal").modal('show');
}
//---------->set title equal to class name of paragraph
function setTitle(projectInfo) {
    var content = document.getElementById(projectInfo).className;

    document.getElementById("whatever").innerText = content;
}

function hoverTitle() {
    document.getElementById("contactMini").style.height = "100px";
    document.getElementById("contactMini").style.opacity = "1";

}

function hoverTitle2() {
    document.getElementById("contactMini").style.height = "0px";
    document.getElementById("contactMini").style.opacity = "0";

}

$(".panel-heading").parent('.panel').hover(
    function () {
        $(this).children('.collapse').collapse('show');
    }, function () {
        $(this).children('.collapse').collapse('hide');
    }
);

