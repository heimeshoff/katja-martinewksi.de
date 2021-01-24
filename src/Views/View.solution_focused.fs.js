import * as react from "react";

export function solution_focused(model, dispatch) {
    return react.createElement("div", {
        className: "w-full md:w-2/3 lg:w-1/2",
        id: "solution focused",
    }, react.createElement("div", {
        className: "flex flex-col md:flex-row items-center justify-center space-x-4 space-y-4 ",
    }, react.createElement("div", {
        className: "md:w-1/2 px-4",
    }, react.createElement("div", {
        className: "font-bold text-gray-700 text-3xl",
    }, "Solution Focused Approach"), react.createElement("p", {
        className: "pr-4 text-justify",
    }, "Der Solution Focused Ansatz konzentriert sich auf die Möglichkeiten, die bereits funktioniert haben und auf das was erreicht werden möchte - Weniger auf die problemerzeugenden Aspekte. Hierdurch helfe ich Dir aus blockierendem Denken zu zukunftsorientiertem Handeln zu kommen."), react.createElement("p", {
        className: "pr-4 text-justify",
    }, "Durch meine Vernetzung mit SFiO (Solution Focus in Organisations) und dem I2A Network kann ich auf viele Ressourcen zurückgreifen.")), react.createElement("div", {
        className: "w-1/2",
    }, react.createElement("a", {
        href: "https://sfio.org/",
        target: "_blank",
    }, react.createElement("img", {
        className: "w-64 shadow-md mb-2",
        src: "/img/sfio.png",
    })), react.createElement("a", {
        href: "https://www.i2a-network.com/",
        target: "_blank",
    }, react.createElement("img", {
        className: "w-64 shadow-md",
        src: "/img/i2a.png",
    })))));
}

