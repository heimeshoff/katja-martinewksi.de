import * as react from "react";
import { ofArray } from "../.fable/fable-library.3.0.1/List.js";

export function about(model, dispatch) {
    return ofArray([react.createElement("div", {
        className: "self-start lg:w-1/2",
    }, react.createElement("div", {
        className: "font-bold text-gray-700 text-3xl",
    }, "About me"), react.createElement("p", {
        className: "text-justify",
    }, "Die Promotion im Fachgebiet Chemie lehrte mir eine wissenschaftliche Denkweise. Die Weiterbildungen zur Führungskraft weckten schließlich mein starkes Interesse am Thema Kommunikation und Gruppendynamiken. Und diese Begeisterung möchte ich mit anderen WissenschaftlerInnen teilen. Gerade als Wissenschaftlerin ist mir Gleichberechtigung ein großes Anliegen. Ich unterstütze ihr Unternehmen gerne bei der Entwicklung eines Bewusstseins im Sinne der Gleichberechtigung.")), react.createElement("div", {
        className: "self-stretch lg:w-1/2 flex flex-col items-center",
        id: "kontakt",
    }, react.createElement("div", {
        className: "font-bold text-gray-700 text-3xl",
    }, "Kontakt"), react.createElement("p", {
        className: "text-justify",
    }, react.createElement("a", {
        className: "hover:text-blue-300",
        href: "mailto:katja.martinewski@i2a-network.com",
    }, "katja.martinewski@i2a-network.com"), react.createElement("div", {}, "+49 (160) 4542358")))]);
}

