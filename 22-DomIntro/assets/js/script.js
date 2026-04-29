document.body.style.background = "#e5e5e5";
document.body.style.display = "flex";
document.body.style.justifyContent = "center";
document.body.style.paddingTop = "40px";

const card = document.createElement("div");
card.className = "property-card";
document.body.appendChild(card);

card.style.position = "relative";
card.style.width = "320px";
card.style.background = "#f9f9f9";
card.style.border = "1px solid #ccc";
card.style.borderRadius = "10px";
card.style.overflow = "hidden";
card.style.fontFamily = "Arial";
card.style.cursor = "pointer";
card.style.transition = "0.3s";


const heart = document.createElement("i");
heart.className = "fa-regular fa-heart favorite-btn";

heart.style.cssText = `
position:absolute;
top:15px;
right:15px;
font-size:22px;
color:white;
cursor:pointer;
z-index:100;
`;

card.appendChild(heart);

heart.addEventListener("click", function (e) {
    e.stopPropagation();
    heart.className =
        heart.className.includes("fa-regular")
            ? "fa-solid fa-heart favorite-btn"
            : "fa-regular fa-heart favorite-btn";

    heart.style.color =
        heart.style.color === "red" ? "white" : "red";
});



card.addEventListener("mouseenter", function () {
    card.style.boxShadow =
        "0 5px 15px rgba(0,0,0,.3)";
});

card.addEventListener("mouseleave", function () {
    card.style.boxShadow = "none";
});


const img = document.createElement("img");
img.src = "https://augueksperts.lv/wp-content/uploads/2013/08/post12-1.jpg";
img.style.width = "100%";
img.style.display = "block";
card.appendChild(img);


const content = document.createElement("div");
content.style.padding = "10px";
card.appendChild(content);

const title = document.createElement("p");
title.innerText = "DETACHED HOUSE · 5Y OLD";
title.style.color = "gray";
content.appendChild(title);

const price = document.createElement("h2");
price.innerText = "$750,000";
content.appendChild(price);

const address = document.createElement("p");
address.innerText = "742 Evergreen Terrace";
address.style.color = "gray";
content.appendChild(address);

const info = document.createElement("div");

info.style.cssText = `
border:1px solid #dad9d9;
background:#f3f3f3;
padding:20px;
display:flex;
gap:15px;
margin:20px 0;
`;

content.appendChild(info);


const bedIcon = document.createElement("span");
bedIcon.innerHTML =
    '<i class="fa-solid fa-bed"></i> 3 Bedrooms';

info.appendChild(bedIcon);


const bathIcon = document.createElement("span");
bathIcon.innerHTML =
    '<i class="fa-solid fa-bath"></i> 2 Bathrooms';

info.appendChild(bathIcon);

const realtor = document.createElement("div");

realtor.style.cssText = `
margin-top:10px;
padding-top:10px;
background:#f3f3f3;
border-top:1px solid #eee;
`;

content.appendChild(realtor);

const realtorTitle = document.createElement("div");
realtorTitle.innerText = "REALTOR";

realtorTitle.style.cssText = `
font-size:12px;
font-weight:bold;
color:#56626a;
margin-bottom:10px;
padding-left:10px;
`;

realtor.appendChild(realtorTitle);

const realtorInfo = document.createElement("div");

realtorInfo.style.cssText = `
display:flex;
align-items:center;
padding:0 10px;
`;

realtor.appendChild(realtorInfo);

const realtorImg = document.createElement("img");
realtorImg.src =
    "https://randomuser.me/api/portraits/women/79.jpg";

realtorImg.style.cssText = `
width:40px;
height:40px;
border-radius:50%;
margin-right:10px;
margin-bottom:10px;
`;

realtorInfo.appendChild(realtorImg);

const details = document.createElement("div");

details.style.cssText = `
display:flex;
flex-direction:column;
gap:5px;
margin-bottom:10px;
`;

realtorInfo.appendChild(details);

const realtorName = document.createElement("span");
realtorName.innerText = "Tiffany Heffner";
realtorName.style.fontSize = "14px";
realtorName.style.fontWeight = "bold";

details.appendChild(realtorName);

const realtorPhone = document.createElement("span");
realtorPhone.innerHTML ='<i class="fa-solid fa-phone"></i> (555) 555-4321';
    
realtorPhone.style.fontSize = "12px";
realtorPhone.style.color = "gray";

details.appendChild(realtorPhone);

card.addEventListener("click", function () {
    console.log("Card kliklendi!");
});