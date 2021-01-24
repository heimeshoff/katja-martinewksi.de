import * as react from "react";

export function coaching(model, dispatch) {
    return react.createElement("div", {
        className: "w-full md:w-2/3 lg:w-1/2",
        id: "coaching \u0026 training",
    }, react.createElement("div", {
        className: "flex flex-col md:flex-row items-center justify-center space-x-4 space-y-4 ",
    }, react.createElement("img", {
        className: "w-1/2 object-contain",
        src: "/img/coaching.png",
    }), react.createElement("div", {
        className: "md:w-1/2",
    }, react.createElement("div", {
        className: "font-bold text-gray-700 text-3xl",
    }, "Coaching \u0026 Training"), react.createElement("p", {
        className: "pr-4 text-justify",
    }, "Falls Du ein Ziel verfolgst und effektiver im Arbeitsleben sein möchtest, aber nicht weißt, wie du es erreichen sollst, kann ich dir durch meine auf dem Prinzip des Solution focused Ansatz basierenden Coaching Methode helfen dieses Ziel zu erreichen."), react.createElement("p", {
        className: "pr-4 text-justify",
    }, "Dich erwarten in Trainings mit mir ein hoher Grad an Interaktion, damit aus Theorie auch Praxis wird."))));
}

