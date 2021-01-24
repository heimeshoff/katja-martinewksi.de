import * as react from "react";
import { Page, Msg } from "../Types.fs.js";

export function anchor(dispatch, label) {
    return react.createElement("div", {
        className: "p-4 text-2xl border-b-2 border-transparent hover:border-red-700 cursor-pointer",
        onClick: (e) => {
            e.stopPropagation();
            dispatch(new Msg(3, label.toLocaleLowerCase()));
        },
    }, label);
}

export function links(model, dispatch) {
    return react.createElement("div", {
        className: "flex flex-col lg:flex-row items-stretch justify-end",
    }, anchor(dispatch, "Coaching"), anchor(dispatch, "Training"), anchor(dispatch, "Solution focused"), anchor(dispatch, "Kontakt"));
}

export function navbar(model, dispatch) {
    const visibility = model.menu_open ? "block" : "hidden";
    return react.createElement("div", {
        className: "z-50 fixed w-full glass bg-white bg-opacity-50 shadow-lg",
    }, react.createElement("div", {
        className: "lg:hidden",
    }, react.createElement("div", {
        className: "w-full flex flex-row items-center justify-between",
    }, react.createElement("div", {
        className: "text-2xl text-gray-800 p-4 cursor-pointer border-b-2 border-transparent hover:border-red-700",
        onClick: (_arg1) => {
            dispatch(new Msg(2, new Page(0)));
        },
    }, "Martinewski"), react.createElement("button", {
        className: "flex-no-shrink flex items-center m-4 px-3 py-2 border rounded hover:border-red-700 hover:text-blue-light hover:border-blue-light",
        onClick: (e) => {
            e.stopPropagation();
            dispatch(new Msg(0));
        },
    }, react.createElement("svg", {
        className: "fill-current h-3 w-3",
        viewBox: "0 0 20 20",
        xmlns: "http://www.w3.org/2000/svg",
    }, react.createElement("path", {
        d: "M0 3h20v2H0V3zm0 6h20v2H0V9zm0 6h20v2H0v-2z",
    })))), react.createElement("div", {
        className: visibility + " bg-white bg-opacity-50 w-full z-25",
    }, links(model, dispatch))), react.createElement("div", {
        className: "hidden lg:flex flex-row items-center justify-center",
        id: "navbar",
    }, react.createElement("div", {
        className: "w-4/5 xl:w-2/3 flex flex-col lg:flex-row items-center justify-between",
    }, react.createElement("div", {
        className: "text-2xl text-gray-800 p-4 cursor-pointer border-b-2 border-transparent hover:border-red-700 ",
        onClick: (_arg2) => {
            dispatch(new Msg(2, new Page(0)));
        },
    }, "Martinewski"), links(model, dispatch))));
}

