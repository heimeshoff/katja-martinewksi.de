import * as react from "react";

export function solution(model, dispatch) {
    return react.createElement("div", {
        className: "content",
        id: "solution focused",
    }, react.createElement("div", {
        className: "my-8 w-4/5 lg:w-2/3 xl:w-1/2 flex flex-col md:flex-row items-start justify-between",
    }, react.createElement("div", {
        className: "md:w-1/2",
    }, react.createElement("h2", {}, "Solution Focussed"), react.createElement("p", {
        className: "italic",
    }, "Problems are for Sissies, I do solutions"), react.createElement("p", {
        className: "pt-4",
    }, "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur.")), react.createElement("div", {
        className: "m-4 md:w-1/3",
    }, react.createElement("img", {
        src: "/img/solution.png",
    }))));
}

