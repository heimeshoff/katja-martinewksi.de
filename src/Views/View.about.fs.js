import * as react from "react";

export function about(model, dispatch) {
    return react.createElement("div", {
        className: "w-full md:w-2/3 lg:w-1/2 py-4",
        id: "about me",
    }, react.createElement("div", {
        className: "flex flex-col md:flex-row items-start justify-center space-x-4 space-y-4 ",
    }, react.createElement("div", {
        className: "md:w-1/2",
    }, react.createElement("div", {
        className: "font-bold text-gray-700 text-3xl",
    }, "About me"), react.createElement("p", {
        className: "pr-4 text-justify",
    }, "Die Promotion im Fachgebiet Chemie lehrte mir eine wissenschaftliche Denkweise. Die Weiterbildungen zur Führungskraft weckten schließlich mein starkes Interesse am Thema Kommunikation und Gruppendynamiken. Und diese Begeisterung möchte ich mit anderen WissenschaftlerInnen teilen. Gerade als Wissenschaftlerin ist mir Gleichberechtigung ein großes Anliegen. Ich unterstütze ihr Unternehmen gerne bei der Entwicklung eines Bewusstseins im Sinne der Gleichberechtigung.")), react.createElement("div", {
        className: "md:w-1/2",
    }, react.createElement("div", {
        className: "font-bold text-gray-700 text-3xl",
    }, "Kontakt"), react.createElement("p", {
        className: "pr-4 text-justify",
    }, react.createElement("a", {
        className: "hover:text-blue-300",
        href: "mailto:katja.martinewski@i2a-network.com",
    }, "katja.martinewski@i2a-network.com"), react.createElement("div", {}, "+49 (160) 4542358")))));
}

