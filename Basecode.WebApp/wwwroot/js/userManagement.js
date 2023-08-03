$(document).ready(function () {
    // Get the current page URL
    var currentURL = window.location.pathname;

    // Loop through the sidebar links to find the matching URL
    $(".sidebar ul li a").each(function() {
        var linkURL = $(this).attr("href");
        if (linkURL === currentURL) {
            $(this).addClass("active"); // Add 'active' class to the matching link
            return false; // Exit the loop early if a match is found
        }
    });
});

/** Open the modal */
var modal = document.getElementById("modal-screen");
var btns = document.querySelectorAll(".edit-btn");
var span = document.getElementsByClassName("close")[0];

// Iterate over each button and attach the click event listener
btns.forEach(function (btn) {
    btn.addEventListener("click", function () {
        // Get the position of the clicked button
        var buttonRect = btn.getBoundingClientRect();
        var buttonTop = buttonRect.top;
        var buttonLeft = buttonRect.left;
        var buttonWidth = buttonRect.width;
        var buttonHeight = buttonRect.height;

        // Calculate the position for the modal to be just below the button
        var modalTop = buttonTop + buttonHeight + 10; // You can adjust this value for spacing

        // Set the position for the modal
        modal.style.top = modalTop + "px";
        modal.style.left = buttonLeft + buttonWidth / 2 + "px"; // Center the modal horizontally

        modal.style.display = "block";
    });
});

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
};

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target === modal) {
        modal.style.display = "none";
    }
};

/** Pagination for table */
// Define the number of items to display per page
const itemsPerPage = 12;

// Get the table and the pagination elements
const table = document.querySelector(".user-table table");
const prevButton = document.getElementById("prev-btn");
const nextButton = document.getElementById("next-btn");
const pageInfo = document.getElementById("page-info");

// Define the current page and total number of results
let currentPage = 1;
const totalResults = table.rows.length - 1; // Excluding the header row

// Function to display the items for the current page
function showPage() {
    const startIndex = (currentPage - 1) * itemsPerPage;
    const endIndex = Math.min(startIndex + itemsPerPage, totalResults);

    // Hide all rows in the table
    for (let i = 1; i < table.rows.length; i++) {
        table.rows[i].style.display = "none";
    }

    // Show the rows for the current page
    for (let i = startIndex + 1; i <= endIndex; i++) {
        table.rows[i].style.display = "table-row";
    }

    // Update the "Showing X-Y of Z results" message
    pageInfo.textContent = `Showing ${
        startIndex + 1
    }-${endIndex} of ${totalResults} results`;
}

// Function to handle the previous button click
prevButton.addEventListener("click", () => {
    if (currentPage > 1) {
        currentPage--;
        showPage();
    }
});

// Function to handle the next button click
nextButton.addEventListener("click", () => {
    const lastPage = Math.ceil(totalResults / itemsPerPage);
    if (currentPage < lastPage) {
        currentPage++;
        showPage();
    }
});

// Display the initial page
showPage();
