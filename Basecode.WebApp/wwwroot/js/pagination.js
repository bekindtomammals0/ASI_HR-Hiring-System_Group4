let infoLinkElements = document.querySelectorAll(".info-pagination-list .info-link");
let statusLinkElements = document.querySelectorAll(".status-pagination-list .status-link");

let infoTableRows = document.querySelectorAll("#applicant-info tr:not(:first-child)");
let statusTableRows = document.querySelectorAll("#applicant-status tr:not(:first-child)");

let infoTotalPageCount = Math.ceil(infoTableRows.length / 5);
let infoCurrentPage = 1;

let statusTotalPageCount = Math.ceil(statusTableRows.length / 5);
let statusCurrentPage = 1;

function showInfoRows(page) {
    let startIndex = (page - 1) * 5;
    let endIndex = startIndex + 5;

    for (let i = 0; i < infoTableRows.length; i++) {
        if (i >= startIndex && i < endIndex) {
            infoTableRows[i].style.display = "table-row";
        } else {
            infoTableRows[i].style.display = "none";
        }
    }
}

function showStatusRows(page) {
    let startIndex = (page - 1) * 5;
    let endIndex = startIndex + 5;

    for (let i = 0; i < statusTableRows.length; i++) {
        if (i >= startIndex && i < endIndex) {
            statusTableRows[i].style.display = "table-row";
        } else {
            statusTableRows[i].style.display = "none";
        }
    }
}

function setInfoActiveLink() {
    let clickedValue = parseInt(event.target.getAttribute("value"));

    if (clickedValue !== infoCurrentPage) {
        infoCurrentPage = clickedValue;
        showInfoRows(infoCurrentPage);
        updateInfoActiveLink();
    }
}

function setStatusActiveLink() {
    let clickedValue = parseInt(event.target.getAttribute("value"));

    if (clickedValue !== statusCurrentPage) {
        statusCurrentPage = clickedValue;
        showStatusRows(statusCurrentPage);
        updateStatusActiveLink();
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

function updateStatusActiveLink() {
    for (let element of statusLinkElements) {
        element.classList.remove("active");

        if (parseInt(element.getAttribute("value")) === statusCurrentPage) {
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

function statusPrevBtn() {
    if (statusCurrentPage > 1) {
        statusCurrentPage--;
        showStatusRows(statusCurrentPage);
        updateStatusActiveLink();
    }
}

function statusNextBtn() {
    if (statusCurrentPage < statusTotalPageCount) {
        statusCurrentPage++;
        showStatusRows(statusCurrentPage);
        updateStatusActiveLink();
    }
}

// Initial setup
showInfoRows(infoCurrentPage);
showStatusRows(statusCurrentPage);
updateInfoActiveLink();
updateStatusActiveLink();
