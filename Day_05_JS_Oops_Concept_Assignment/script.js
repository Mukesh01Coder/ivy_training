/* Fill your code*/
class Blog {
    constructor(title, detail) {
        this.title = title;
        this.detail = detail;
    }

    addTitle() {
        var title_card = document.createElement('h1');
        title_card.setAttribute("id", "blog-title");
       // console.log(title_card);
        document.getElementById('card-text').appendChild(title_card);
        title_card.innerHTML += this.title;
    }
    addDescription() {
        var desc_card = document.createElement('p');
        desc_card.setAttribute("id", "blog-description");
       // console.log(desc_card);
        document.getElementById('card-text').appendChild(desc_card);
        desc_card.innerHTML += this.detail;
    }
}


let ele = document.getElementById('addBlog');
let popupContactEle = document.getElementById('popupContact');
let title = document.getElementById('title');
let desc = document.getElementById('detail');
let ele1 = document.getElementById('post');

ele.onclick = function () {
   
    popupContactEle.setAttribute('style', 'display: block');
    title.value = null;
    desc.value = null;
}


ele1.addEventListener('click', function () {
   
    let img = document.createElement('img');
    img.src = "./assets/java card image.svg";
    img.alt = "Image";
    document.getElementById('card-text').append(img);
   
    p = new Blog(title.value, desc.value);
    p.addTitle();
    p.addDescription();
   
    popupContactEle.removeAttribute('style', 'display:none');
});
