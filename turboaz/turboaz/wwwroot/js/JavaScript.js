var a;
$(".category-list a").click(function () {
    a = $(this).attr("cat")
    $(".vip-product .vip-products").hide()
    $("."+a).show()
})

document.querySelectorAll(".asagi img").forEach(img => {
    img.addEventListener("click", function () {
        document.querySelector(".yuxari img").src = img.src
    })
})
document.querySelector("#CarPhotoSelect").addEventListener("change", function () {
    let item = document.createElement("div");
    item.className = "item"
    let img = document.createElement("img")
    img.src = URL.createObjectURL(this.files[0])
    item.appendChild(img) 
    item.appendChild(this.cloneNode(true)) 
    this.value = null
    item.addEventListener("click", function () {
        this.remove()
    })
    document.querySelector(".photoarea").appendChild(item);
})