function loadPartialView() {
    $(".partial").each((_, partial) => {
        var url = window.location.origin + $(partial).data("url");

        $(partial).load(url, (response, textStatus, xhr) => {
            if (textStatus == "error") {
                $(".spinner-wrapper").hide();
                $(partial).append(
                    `<div class="alert alert-danger partial-error" role="alert">
					    Something went wrong. Can\'t Retrieve list of products.
				    </div >`
                );
            }
        })
    })
}