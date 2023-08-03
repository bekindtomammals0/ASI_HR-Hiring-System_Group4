/** for modal screen */
var modal = document.getElementById("modal-screen");
var btns = document.querySelectorAll(".view-btn");
var span = document.getElementsByClassName("close")[0];

// Iterate over each button and attach the click event listener
btns.forEach(function (btn) {
    btn.addEventListener("click", function () {
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

/** for update button text in applicant details column */
function updateViewBtnText(button) {
    // Get the status text from the previous sibling element of the parent node
    let status = button.parentNode.previousElementSibling.textContent.trim();

    // Get the scheduled date text from the second previous sibling element of the parent node
    let scheduledDate =
        button.parentNode.previousElementSibling.previousElementSibling.textContent.trim();

    let buttonText;

    if (status === "For Screening") {
        buttonText = "View CV";
    } else if (
        status === "For Technical Exam" ||
        status === "For Technical Interview" ||
        status === "For HR Interview"
    ) {
        // Check if the scheduled date is "N/A"
        if (scheduledDate === "N/A") {
            buttonText = "Set Schedule";
        } else {
            buttonText = "Reset Schedule";
        }
    } else {
        buttonText = "View CV";
        // Disable the button if the status doesn't match any expected values
        button.disabled = true;
    }

    // Set the button text based on the determined value
    button.textContent = buttonText;
}

// Attach the event handlers to existing buttons
document.addEventListener("DOMContentLoaded", function () {
    let buttons = document.querySelectorAll(".view-btn");
    buttons.forEach(function (button) {
        button.onclick = function () {
            updateViewBtnText(this);
        };
    });
});

/** for search bar */
const searchInput = document.getElementById("searchInput");

searchInput.addEventListener("input", function () {
    const filter = searchInput.value.toUpperCase();
    const table = document.getElementById("applicant-info");
    const rows = table.getElementsByTagName("tr");

    for (let i = 1; i < rows.length; i++) { // Start from 1 to skip header row
        const nameColumn = rows[i].getElementsByTagName("td")[1];
        if (nameColumn) {
            const name = nameColumn.textContent || nameColumn.innerText;
            if (name.toUpperCase().indexOf(filter) > -1) {
                rows[i].style.display = "";
            } else {
                rows[i].style.display = "none";
            }
        }
    }
});
