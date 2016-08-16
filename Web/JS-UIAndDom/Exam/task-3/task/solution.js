function solve() {
	return function() {
		var template = [
			'<h1>{{title}}</h1>' +
			'<ul>'+
				
					'{{#each posts}}'+
					'<li>' +
					'<div class="post">' + 
						'<p class="author">'+
							'{{#if this.author}}'+
								'<a class="user" href="/user/{{this.author}}">'+
									'{{this.author}}'+
								'</a>'+
							'{{else}}' +
								'<a class="anonymous">Anonymous</a>'+
							'{{/if}}' + 
						'</p>' +
						'<pre class="content">{{{this.text}}}</pre>' +
					'</div>' +
					'<ul>' +
						'{{#each this.comments}}' +
							'{{#unless this.deleted}}' + 	
								'<li>' +
									'<div class="comment">' +
										'{{#if this.author}}'+
										'<p class="author">' +
												'<a class="user" href="/user/{{this.author}}">'+
													'{{this.author}}'+ 
												'</a>' +
										'</p>' +
										'{{else}}' +
											'<p class="author"><a class="anonymous">Anonymous</a></p>'+
										'{{/if}}' + 
										
										
										'<pre class="content">{{{this.text}}}</pre>' +
										
									'</div>' +
								'</li>' +
							'{{/unless}}'+
						'{{/each}}' +
					'</ul>' +
				'</li>'+
				'{{/each}}' +
			'</ul>'+
			'</div>'
		].join('\n');

		return template;
	}
}

// submit the above

if(typeof module !== 'undefined') {
	module.exports = solve;
}
