const API = "https://jsonplaceholder.typicode.com/users";

window.onload = async () => {
    try {
        const fetchResponse = await fetch(API)
        const data = await fetchResponse.json();
        let html = "";
        let modal = "";
        data.forEach(element => {
            html += `
        <div class="main-cards" data-bs-toggle="modal" data-bs-target="#exampleModal">
        <div class="main-cabecalho">
            <h2>${element.name}</h2>
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

        data.forEach(element => {
            modal = `
            
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel">Estatísticas</h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <h2>Estatísticas</h2>
                        <div class="modal-times">
                            <div>
                            <img src="./img/Flags/br.png" alt="">
                            <ul>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                            </ul>
                            </div>
                            <div>
                                <ul>
                                <img class="img-mid" src="./img/Flags/clean.svg" alt="">
                                    <li>Dados</li>
                                    <li>Dados</li>
                                    <li>Dados</li>
                                    <li>Dados</li>
                                    <li>Dados</li>
                                    <li>Dados</li>
                                    <li>Dados</li>
                                    <li>Dados</li>
                                    <li>Dados</li>
                                    <li>Dados</li>
                                </ul>
                            </div>
                            <div><img src="./img/Flags/fr.png" alt="">
                            <ul>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                                <li>${element.address.suite}</li>
                            </ul></div>
                        </div>
                    </div>
                    <div class="modal-footer">
                        
                    </div>
                </div>
            </div>
            `
        })
        document.getElementById("exampleModal").innerHTML = modal;
        document.getElementById("m-container").innerHTML = html;
    } catch (error) {
        return error;
    }
}