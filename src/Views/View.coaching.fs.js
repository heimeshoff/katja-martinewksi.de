import * as react from "react";
import { ofArray } from "../.fable/fable-library.3.0.1/List.js";

export function coaching(model, dispatch) {
    return ofArray([react.createElement("div", {
        className: "md:w-3/4 lg:w-1/2",
    }, react.createElement("div", {
        className: "font-bold text-gray-700 text-3xl",
    }, "Coaching \u0026 Training"), react.createElement("p", {
        className: "text-justify",
    }, "Falls Du ein Ziel verfolgst und effektiver im Arbeitsleben sein möchtest, aber nicht weißt, wie du es erreichen sollst, kann ich dir durch meine auf dem Prinzip des Solution focused Ansatz basierenden Coaching Methode helfen dieses Ziel zu erreichen."), react.createElement("p", {
        className: "text-justify",
    }, "Dich erwarten in Trainings mit mir ein hoher Grad an Interaktion, damit aus Theorie auch Praxis wird.")), react.createElement("img", {
        className: "lg:w-1/2 object-contain max-h-64",
        src: "/img/coaching.png",
    })]);
}

