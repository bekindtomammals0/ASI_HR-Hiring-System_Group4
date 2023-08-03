let infoLinkElements = document.querySelectorAll(
    ".info-pagination-list .info-link"
);
let infoTableRows = document.querySelectorAll(
    "#applicant-info tr:not(:first-child)"
);
let infoTotalPageCount = Math.ceil(infoTableRows.length / 10);
let infoCurrentPage = 1;

function showInfoRows(page) {
    let startIndex = (page - 1) * 10;
    let endIndex = startIndex + 10;

    for (let i = 0; i < infoTableRows.length; i++) {
        if (i >= startIndex && i < endIndex) {
            infoTableRows[i].style.display = "table-row";
        } else {
            infoTableRows[i].style.display = "none";
        }
    }
}

function setInfoActiveLink(event) {
    let clickedValue = parseInt(event.target.getAttribute("value"));

    if (clickedValue !== infoCurrentPage) {
        infoCurrentPage = clickedValue;
        showInfoRows(infoCurrentPage);
        updateInfoActiveLink();
    }
}

function updateInfoActiveLink() {
    for (let element of infoLinkElements) {
        element.classList.remove("active");

        if (parseInt(element.getAttribute("value")) === infoCurrentPage) {
            element.classList.add("active");
        }
    }
}

function infoPrevBtn() {
    if (infoCurrentPage > 1) {
        infoCurrentPage--;
        showInfoRows(infoCurrentPage);
        updateInfoActiveLink();
    }
}

function infoNextBtn() {
    if (infoCurrentPage < infoTotalPageCount) {
        infoCurrentPage++;
        showInfoRows(infoCurrentPage);
        updateInfoActiveLink();
    }
}

document.getElementById("info-prev-btn").addEventListener("click", infoPrevBtn);
document.getElementById("info-next-btn").addEventListener("click", infoNextBtn);

// Event Listener for Info Links
for (let element of infoLinkElements) {
    element.addEventListener("click", setInfoActiveLink);
}

// Initial setup
showInfoRows(infoCurrentPage);
updateInfoActiveLink();
