import * as react from "react";
import { ofArray } from "../.fable/fable-library.3.0.1/List.js";

export function solution_focused(model, dispatch) {
    return ofArray([react.createElement("div", {
        className: "w-1/2 flex flex-col items-center",
    }, react.createElement("a", {
        href: "https://sfio.org/",
        target: "_blank",
    }, react.createElement("img", {
        className: "w-64 mb-4 floating-action-button",
        src: "/img/sfio.png",
    })), react.createElement("a", {
        href: "https://www.i2a-network.com/",
        target: "_blank",
    }, react.createElement("img", {
        className: "w-64 floating-action-button",
        src: "/img/i2a.png",
    }))), react.createElement("div", {
        className: "md:w-3/4 lg:w-1/2",
    }, react.createElement("div", {
        className: "font-bold text-gray-700 text-3xl",
    }, "Solution Focused Approach"), react.createElement("p", {
        className: "text-justify",
    }, "Der Solution Focused Ansatz konzentriert sich auf die Möglichkeiten, die bereits funktioniert haben und auf das was erreicht werden möchte - Weniger auf die problemerzeugenden Aspekte. Hierdurch helfe ich Dir aus blockierendem Denken zu zukunftsorientiertem Handeln zu kommen."), react.createElement("p", {
        className: "text-justify",
    }, "Durch meine Vernetzung mit SFiO (Solution Focus in Organisations) und dem I2A Network kann ich auf viele Ressourcen zurückgreifen."))]);
}

