const API = "https://jsonplaceholder.typicode.com/photos";

window.onload = async () => {
    try {
        const fetchResponse = await fetch(API)
        const data = await fetchResponse.json();
        let html = "";
        data.forEach(element => {
            html += `
            <div class="main-cards">
            <div class="main-cabecalho">
                <h2>${element.title}</h2>
            </div>
            <div class="main-content">
                <div class="main-teams">
                    <img src=${element.thumbnailUrl} alt="">
                    <div class="main-result">
                        <span class="gols-left">3</span>
                        <span>X</span>
                        <span class="gols-right">3</span>
                    </div>
                    <img src=${element.thumbnailUrl} alt="">
                </div>
            </div>
            <div class="main-footer">
            </div>
            <p>15/10/2022</p>
        </div>
            `
        });
        document.getElementById("m-container").innerHTML = html;
    } catch (error) {
        return error;
    }
}