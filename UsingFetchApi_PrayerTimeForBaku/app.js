
class Data{

    async getPayerTime(){
        let dateTime
        let date = document.getElementById("date").value
        const payerRespons = await fetch(`https://api.pray.zone/v2/times/day.json?city=baku&date=${date}`)
        .then(respon=>respon.json())
        .then(res=>res.results.datetime[0].times)
        .then(res=>{dateTime=res})

        let html = ""
        for(var i in dateTime){
            html+=`
            <tr>
                <th scope="row">${i}</th>
                <td>${dateTime[i]}</td>
            </tr>
            `
        }

        document.getElementById('data-container').innerHTML =html;
    }

}

document.getElementById('form').addEventListener('submit',function(e){
    e.preventDefault();
    
    let data = new Data();
    data.getPayerTime()

})


