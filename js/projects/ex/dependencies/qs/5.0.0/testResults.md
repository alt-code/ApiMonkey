<testsuite name="Mocha Tests" tests="806" failures="0" errors="0" skipped="0" timestamp="Sat, 02 Apr 2016 05:59:49 GMT" time="4.249">
<testcase classname="Route .all" name="should add handler" time="0.003"/>
<testcase classname="Route .all" name="should handle VERBS" time="0.004"/>
<testcase classname="Route .all" name="should stack" time="0.001"/>
<testcase classname="Route .VERB" name="should support .get" time="0.001"/>
<testcase classname="Route .VERB" name="should limit to just .VERB" time="0.001"/>
<testcase classname="Route .VERB" name="should allow fallthrough" time="0.001"/>
<testcase classname="Route errors" name="should handle errors via arity 4 functions" time="0.001"/>
<testcase classname="Route errors" name="should handle throw" time="0.001"/>
<testcase classname="Route errors" name="should handle throwing inside error handlers" time="0"/>
<testcase classname="Route errors" name="should handle throw in .all" time="0"/>
<testcase classname="Route errors" name="should handle single error handler" time="0"/>
<testcase classname="Router" name="should return a function with router methods" time="0"/>
<testcase classname="Router" name="should support .use of other routers" time="0.003"/>
<testcase classname="Router" name="should support dynamic routes" time="0.002"/>
<testcase classname="Router" name="should handle blank URL" time="0.003"/>
<testcase classname="Router" name="should not stack overflow with many registered routes" time="0.274"/>
<testcase classname="Router .handle" name="should dispatch" time="0.001"/>
<testcase classname="Router .multiple callbacks" name="should throw if a callback is null" time="0"/>
<testcase classname="Router .multiple callbacks" name="should throw if a callback is undefined" time="0.001"/>
<testcase classname="Router .multiple callbacks" name="should throw if a callback is not a function" time="0"/>
<testcase classname="Router .multiple callbacks" name="should not throw if all callbacks are functions" time="0"/>
<testcase classname="Router error" name="should skip non error middleware" time="0.001"/>
<testcase classname="Router error" name="should handle throwing inside routes with params" time="0.001"/>
<testcase classname="Router error" name="should handle throwing in handler after async param" time="0.001"/>
<testcase classname="Router error" name="should handle throwing inside error handlers" time="0.001"/>
<testcase classname="Router FQDN" name="should not obscure FQDNs" time="0.004"/>
<testcase classname="Router FQDN" name="should ignore FQDN in search" time="0.001"/>
<testcase classname="Router FQDN" name="should ignore FQDN in path" time="0.001"/>
<testcase classname="Router FQDN" name="should adjust FQDN req.url" time="0.002"/>
<testcase classname="Router FQDN" name="should adjust FQDN req.url with multiple handlers" time="0"/>
<testcase classname="Router FQDN" name="should adjust FQDN req.url with multiple routed handlers" time="0.001"/>
<testcase classname="Router .all" name="should support using .all to capture all http verbs" time="0.001"/>
<testcase classname="Router .use" name="should require arguments" time="0.001"/>
<testcase classname="Router .use" name="should not accept non-functions" time="0.001"/>
<testcase classname="Router .use" name="should accept array of middleware" time="0"/>
<testcase classname="Router .param" name="should call param function when routing VERBS" time="0"/>
<testcase classname="Router .param" name="should call param function when routing middleware" time="0.001"/>
<testcase classname="Router .param" name="should only call once per request" time="0"/>
<testcase classname="Router .param" name="should call when values differ" time="0.001"/>
<testcase classname="Router parallel requests" name="should not mix requests" time="0.055"/>
<testcase classname="app.all()" name="should add a router per method" time="0.051"/>
<testcase classname="app.all()" name="should run the callback for a method just once" time="0.005"/>
<testcase classname="app.del()" name="should alias app.delete()" time="0.002"/>
<testcase classname="app .engine(ext, fn)" name="should map a template engine" time="0.003"/>
<testcase classname="app .engine(ext, fn)" name="should throw when the callback is missing" time="0"/>
<testcase classname="app .engine(ext, fn)" name="should work without leading &quot;.&quot;" time="0.002"/>
<testcase classname="app .engine(ext, fn)" name="should work &quot;view engine&quot; setting" time="0.001"/>
<testcase classname="app .engine(ext, fn)" name="should work &quot;view engine&quot; with leading &quot;.&quot;" time="0.001"/>
<testcase classname="HEAD" name="should default to GET" time="0.006"/>
<testcase classname="HEAD" name="should output the same headers as GET requests" time="0.013"/>
<testcase classname="app.head()" name="should override" time="0.003"/>
<testcase classname="app" name="should inherit from event emitter" time="0"/>
<testcase classname="app" name="should be callable" time="0.001"/>
<testcase classname="app" name="should 404 without routes" time="0.002"/>
<testcase classname="app.parent" name="should return the parent when mounted" time="0.001"/>
<testcase classname="app.mountpath" name="should return the mounted path" time="0.002"/>
<testcase classname="app.router" name="should throw with notice" time="0.001"/>
<testcase classname="app.path()" name="should return the canonical" time="0.001"/>
<testcase classname="in development" name="should disable &quot;view cache&quot;" time="0.001"/>
<testcase classname="in production" name="should enable &quot;view cache&quot;" time="0"/>
<testcase classname="without NODE_ENV" name="should default to development" time="0.001"/>
<testcase classname="app.listen()" name="should wrap with an HTTP server" time="0.001"/>
<testcase classname="app .locals(obj)" name="should merge locals" time="0.001"/>
<testcase classname="app .locals.settings" name="should expose app settings" time="0.002"/>
<testcase classname="OPTIONS" name="should default to the routes defined" time="0.003"/>
<testcase classname="OPTIONS" name="should only include each method once" time="0.005"/>
<testcase classname="OPTIONS" name="should not be affected by app.all" time="0.005"/>
<testcase classname="OPTIONS" name="should not respond if the path is not defined" time="0.004"/>
<testcase classname="OPTIONS" name="should forward requests down the middleware chain" time="0.004"/>
<testcase classname="OPTIONS when error occurs in respone handler" name="should pass error to callback" time="0.006"/>
<testcase classname="app.options()" name="should override the default behavior" time="0.006"/>
<testcase classname="app .param(fn)" name="should map app.param(name, ...) logic" time="0.008"/>
<testcase classname="app .param(fn)" name="should fail if not given fn" time="0.002"/>
<testcase classname="app .param(names, fn)" name="should map the array" time="0.017"/>
<testcase classname="app .param(name, fn)" name="should map logic for a single param" time="0.008"/>
<testcase classname="app .param(name, fn)" name="should only call once per request" time="0.009"/>
<testcase classname="app .param(name, fn)" name="should call when values differ" time="0.009"/>
<testcase classname="app .param(name, fn)" name="should support altering req.params across routes" time="0.006"/>
<testcase classname="app .param(name, fn)" name="should not invoke without route handler" time="0.006"/>
<testcase classname="app .param(name, fn)" name="should work with encoded values" time="0.003"/>
<testcase classname="app .param(name, fn)" name="should catch thrown error" time="0.007"/>
<testcase classname="app .param(name, fn)" name="should catch thrown secondary error" time="0.004"/>
<testcase classname="app .param(name, fn)" name="should defer to next route" time="0.003"/>
<testcase classname="app .param(name, fn)" name="should defer all the param routes" time="0.006"/>
<testcase classname="app .param(name, fn)" name="should not call when values differ on error" time="0.008"/>
<testcase classname="app .param(name, fn)" name="should call when values differ when using &quot;next&quot;" time="0.004"/>
<testcase classname="app .render(name, fn)" name="should support absolute paths" time="0.002"/>
<testcase classname="app .render(name, fn)" name="should support absolute paths with &quot;view engine&quot;" time="0.002"/>
<testcase classname="app .render(name, fn)" name="should expose app.locals" time="0.001"/>
<testcase classname="app .render(name, fn)" name="should support index.&lt;engine&gt;" time="0.001"/>
<testcase classname="app .render(name, fn)" name="should handle render error throws" time="0.001"/>
<testcase classname="app .render(name, fn) when the file does not exist" name="should provide a helpful error" time="0.001"/>
<testcase classname="app .render(name, fn) when an error occurs" name="should invoke the callback" time="0.002"/>
<testcase classname="app .render(name, fn) when an extension is given" name="should render the template" time="0.001"/>
<testcase classname="app .render(name, fn) when &quot;view engine&quot; is given" name="should render the template" time="0.001"/>
<testcase classname="app .render(name, fn) when &quot;views&quot; is given" name="should lookup the file in the path" time="0.002"/>
<testcase classname="app .render(name, fn) when &quot;views&quot; is given when array of paths" name="should lookup the file in the path" time="0"/>
<testcase classname="app .render(name, fn) when &quot;views&quot; is given when array of paths" name="should lookup in later paths until found" time="0.001"/>
<testcase classname="app .render(name, fn) when &quot;views&quot; is given when array of paths" name="should error if file does not exist" time="0.004"/>
<testcase classname="app .render(name, fn) when a &quot;view&quot; constructor is given" name="should create an instance of it" time="0.001"/>
<testcase classname="app .render(name, fn) caching" name="should always lookup view without cache" time="0.001"/>
<testcase classname="app .render(name, fn) caching" name="should cache with &quot;view cache&quot; setting" time="0.001"/>
<testcase classname="app .render(name, options, fn)" name="should render the template" time="0.002"/>
<testcase classname="app .render(name, options, fn)" name="should expose app.locals" time="0"/>
<testcase classname="app .render(name, options, fn)" name="should give precedence to app.render() locals" time="0"/>
<testcase classname="app .render(name, options, fn) caching" name="should cache with cache option" time="0.002"/>
<testcase classname="app .request" name="should extend the request prototype" time="0.009"/>
<testcase classname="app .response" name="should extend the response prototype" time="0.008"/>
<testcase classname="app .response" name="should not be influenced by other app protos" time="0.003"/>
<testcase classname="app.route" name="should return a new route" time="0.004"/>
<testcase classname="app.route" name="should all .VERB after .all" time="0.004"/>
<testcase classname="app.route" name="should support dynamic routes" time="0.004"/>
<testcase classname="app.route" name="should not error on empty routes" time="0.002"/>
<testcase classname="app.router" name="should restore req.params after leaving router" time="0.002"/>
<testcase classname="app.router" name="should be .use()able" time="0.004"/>
<testcase classname="app.router" name="should allow escaped regexp" time="0.008"/>
<testcase classname="app.router" name="should allow literal &quot;.&quot;" time="0.003"/>
<testcase classname="app.router" name="should allow rewriting of the url" time="0.004"/>
<testcase classname="app.router" name="should run in order added" time="0.007"/>
<testcase classname="app.router" name="should be chainable" time="0.001"/>
<testcase classname="app.router methods" name="should include ACL" time="0.016"/>
<testcase classname="app.router methods" name="should reject numbers for app.acl" time="0"/>
<testcase classname="app.router methods" name="should include BIND" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.bind" time="0.001"/>
<testcase classname="app.router methods" name="should include CHECKOUT" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.checkout" time="0"/>
<testcase classname="app.router methods" name="should include COPY" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.copy" time="0"/>
<testcase classname="app.router methods" name="should include DELETE" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.delete" time="0"/>
<testcase classname="app.router methods" name="should include GET" time="0.005"/>
<testcase classname="app.router methods" name="should reject numbers for app.get" time="0.001"/>
<testcase classname="app.router methods" name="should include HEAD" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.head" time="0.002"/>
<testcase classname="app.router methods" name="should include LINK" time="0.009"/>
<testcase classname="app.router methods" name="should reject numbers for app.link" time="0.001"/>
<testcase classname="app.router methods" name="should include LOCK" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.lock" time="0"/>
<testcase classname="app.router methods" name="should include M-SEARCH" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.m-search" time="0"/>
<testcase classname="app.router methods" name="should include MERGE" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.merge" time="0.001"/>
<testcase classname="app.router methods" name="should include MKACTIVITY" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.mkactivity" time="0.001"/>
<testcase classname="app.router methods" name="should include MKCALENDAR" time="0.001"/>
<testcase classname="app.router methods" name="should reject numbers for app.mkcalendar" time="0.001"/>
<testcase classname="app.router methods" name="should include MKCOL" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.mkcol" time="0.001"/>
<testcase classname="app.router methods" name="should include MOVE" time="0.008"/>
<testcase classname="app.router methods" name="should reject numbers for app.move" time="0"/>
<testcase classname="app.router methods" name="should include NOTIFY" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.notify" time="0.001"/>
<testcase classname="app.router methods" name="should include OPTIONS" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.options" time="0"/>
<testcase classname="app.router methods" name="should include PATCH" time="0.007"/>
<testcase classname="app.router methods" name="should reject numbers for app.patch" time="0.001"/>
<testcase classname="app.router methods" name="should include POST" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.post" time="0.001"/>
<testcase classname="app.router methods" name="should include PROPFIND" time="0.014"/>
<testcase classname="app.router methods" name="should reject numbers for app.propfind" time="0.001"/>
<testcase classname="app.router methods" name="should include PROPPATCH" time="0.001"/>
<testcase classname="app.router methods" name="should reject numbers for app.proppatch" time="0"/>
<testcase classname="app.router methods" name="should include PURGE" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.purge" time="0.001"/>
<testcase classname="app.router methods" name="should include PUT" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.put" time="0.001"/>
<testcase classname="app.router methods" name="should include REBIND" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.rebind" time="0.001"/>
<testcase classname="app.router methods" name="should include REPORT" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.report" time="0"/>
<testcase classname="app.router methods" name="should include SEARCH" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.search" time="0.001"/>
<testcase classname="app.router methods" name="should include SUBSCRIBE" time="0.006"/>
<testcase classname="app.router methods" name="should reject numbers for app.subscribe" time="0.001"/>
<testcase classname="app.router methods" name="should include TRACE" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.trace" time="0.001"/>
<testcase classname="app.router methods" name="should include UNBIND" time="0.002"/>
<testcase classname="app.router methods" name="should reject numbers for app.unbind" time="0"/>
<testcase classname="app.router methods" name="should include UNLINK" time="0.003"/>
<testcase classname="app.router methods" name="should reject numbers for app.unlink" time="0.001"/>
<testcase classname="app.router methods" name="should include UNLOCK" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.unlock" time="0"/>
<testcase classname="app.router methods" name="should include UNSUBSCRIBE" time="0.004"/>
<testcase classname="app.router methods" name="should reject numbers for app.unsubscribe" time="0"/>
<testcase classname="app.router methods" name="should include DEL" time="0.001"/>
<testcase classname="app.router methods" name="should reject numbers for app.del" time="0"/>
<testcase classname="app.router methods" name="should re-route when method is altered" time="0.005"/>
<testcase classname="app.router decode querystring" name="should decode correct params" time="0.005"/>
<testcase classname="app.router decode querystring" name="should not accept params in malformed paths" time="0.004"/>
<testcase classname="app.router decode querystring" name="should not decode spaces" time="0.003"/>
<testcase classname="app.router decode querystring" name="should work with unicode" time="0.004"/>
<testcase classname="app.router when given a regexp" name="should match the pathname only" time="0.006"/>
<testcase classname="app.router when given a regexp" name="should populate req.params with the captures" time="0.005"/>
<testcase classname="app.router case sensitivity" name="should be disabled by default" time="0.002"/>
<testcase classname="app.router case sensitivity when &quot;case sensitive routing&quot; is enabled" name="should match identical casing" time="0.003"/>
<testcase classname="app.router case sensitivity when &quot;case sensitive routing&quot; is enabled" name="should not match otherwise" time="0.004"/>
<testcase classname="app.router params" name="should overwrite existing req.params by default" time="0.004"/>
<testcase classname="app.router params" name="should allow merging existing req.params" time="0.003"/>
<testcase classname="app.router params" name="should use params from router" time="0.002"/>
<testcase classname="app.router params" name="should merge numeric indices req.params" time="0.002"/>
<testcase classname="app.router params" name="should merge numeric indices req.params when more in parent" time="0.006"/>
<testcase classname="app.router params" name="should merge numeric indices req.params when parent has same number" time="0.005"/>
<testcase classname="app.router params" name="should ignore invalid incoming req.params" time="0.004"/>
<testcase classname="app.router params" name="should restore req.params" time="0.006"/>
<testcase classname="app.router trailing slashes" name="should be optional by default" time="0.004"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match trailing slashes" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should pass-though middleware" time="0.003"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should pass-though mounted middleware" time="0.004"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match no slashes" time="0.003"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match middleware when omitting the trailing slash" time="0.003"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match middleware" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should match middleware when adding the trailing slash" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should fail when omitting the trailing slash" time="0.002"/>
<testcase classname="app.router trailing slashes when &quot;strict routing&quot; is enabled" name="should fail when adding the trailing slash" time="0.002"/>
<testcase classname="app.router *" name="should denote a greedy capture group" time="0.004"/>
<testcase classname="app.router *" name="should work with several" time="0.003"/>
<testcase classname="app.router *" name="should work cross-segment" time="0.005"/>
<testcase classname="app.router *" name="should allow naming" time="0.004"/>
<testcase classname="app.router *" name="should not be greedy immediately after param" time="0.006"/>
<testcase classname="app.router *" name="should eat everything after /" time="0.003"/>
<testcase classname="app.router *" name="should span multiple segments" time="0.002"/>
<testcase classname="app.router *" name="should be optional" time="0.003"/>
<testcase classname="app.router *" name="should require a preceding /" time="0.004"/>
<testcase classname="app.router *" name="should keep correct parameter indexes" time="0.004"/>
<testcase classname="app.router *" name="should work within arrays" time="0.002"/>
<testcase classname="app.router :name" name="should denote a capture group" time="0.002"/>
<testcase classname="app.router :name" name="should match a single segment only" time="0.002"/>
<testcase classname="app.router :name" name="should allow several capture groups" time="0.003"/>
<testcase classname="app.router :name" name="should work following a partial capture group" time="0.004"/>
<testcase classname="app.router :name" name="should work inside literal paranthesis" time="0.003"/>
<testcase classname="app.router :name" name="should work in array of paths" time="0.005"/>
<testcase classname="app.router :name?" name="should denote an optional capture group" time="0.006"/>
<testcase classname="app.router :name?" name="should populate the capture group" time="0.006"/>
<testcase classname="app.router .:name" name="should denote a format" time="0.016"/>
<testcase classname="app.router .:name?" name="should denote an optional format" time="0.004"/>
<testcase classname="app.router when next() is called" name="should continue lookup" time="0.005"/>
<testcase classname="app.router when next(&quot;route&quot;) is called" name="should jump to next route" time="0.018"/>
<testcase classname="app.router when next(err) is called" name="should break out of app.router" time="0.004"/>
<testcase classname="app.router when next(err) is called" name="should call handler in same route, if exists" time="0.003"/>
<testcase classname="app .VERB()" name="should not get invoked without error handler on error" time="0.003"/>
<testcase classname="app .VERB()" name="should only call an error handling routing callback when an error is propagated" time="0.005"/>
<testcase classname="app" name="should emit &quot;mount&quot; when mounted" time="0.002"/>
<testcase classname="app .use(app)" name="should mount the app" time="0.003"/>
<testcase classname="app .use(app)" name="should support mount-points" time="0.003"/>
<testcase classname="app .use(app)" name="should set the child's .parent" time="0.001"/>
<testcase classname="app .use(app)" name="should support dynamic routes" time="0.004"/>
<testcase classname="app .use(app)" name="should support mounted app anywhere" time="0.004"/>
<testcase classname="app .use(middleware)" name="should accept multiple arguments" time="0.003"/>
<testcase classname="app .use(middleware)" name="should invoke middleware for all requests" time="0.006"/>
<testcase classname="app .use(middleware)" name="should accept array of middleware" time="0.005"/>
<testcase classname="app .use(middleware)" name="should accept multiple arrays of middleware" time="0.004"/>
<testcase classname="app .use(middleware)" name="should accept nested arrays of middleware" time="0.002"/>
<testcase classname="app .use(path, middleware)" name="should reject missing functions" time="0.001"/>
<testcase classname="app .use(path, middleware)" name="should reject non-functions as middleware" time="0.001"/>
<testcase classname="app .use(path, middleware)" name="should strip path from req.url" time="0.002"/>
<testcase classname="app .use(path, middleware)" name="should accept multiple arguments" time="0.004"/>
<testcase classname="app .use(path, middleware)" name="should invoke middleware for all requests starting with path" time="0.006"/>
<testcase classname="app .use(path, middleware)" name="should work if path has trailing slash" time="0.004"/>
<testcase classname="app .use(path, middleware)" name="should accept array of middleware" time="0.002"/>
<testcase classname="app .use(path, middleware)" name="should accept multiple arrays of middleware" time="0.002"/>
<testcase classname="app .use(path, middleware)" name="should accept nested arrays of middleware" time="0.004"/>
<testcase classname="app .use(path, middleware)" name="should support array of paths" time="0.007"/>
<testcase classname="app .use(path, middleware)" name="should support array of paths with middleware array" time="0.01"/>
<testcase classname="app .use(path, middleware)" name="should support regexp path" time="0.009"/>
<testcase classname="app .use(path, middleware)" name="should support empty string path" time="0.003"/>
<testcase classname="config .set()" name="should set a value" time="0"/>
<testcase classname="config .set()" name="should return the app" time="0"/>
<testcase classname="config .set()" name="should return the app when undefined" time="0"/>
<testcase classname="config .set() &quot;etag&quot;" name="should throw on bad value" time="0.001"/>
<testcase classname="config .set() &quot;etag&quot;" name="should set &quot;etag fn&quot;" time="0"/>
<testcase classname="config .set() &quot;trust proxy&quot;" name="should set &quot;trust proxy fn&quot;" time="0.001"/>
<testcase classname="config .get()" name="should return undefined when unset" time="0"/>
<testcase classname="config .get()" name="should otherwise return the value" time="0"/>
<testcase classname="config .get() when mounted" name="should default to the parent app" time="0.001"/>
<testcase classname="config .get() when mounted" name="should given precedence to the child" time="0.001"/>
<testcase classname="config .get() when mounted" name="should inherit &quot;trust proxy&quot; setting" time="0"/>
<testcase classname="config .get() when mounted" name="should prefer child &quot;trust proxy&quot; setting" time="0.001"/>
<testcase classname="config .enable()" name="should set the value to true" time="0"/>
<testcase classname="config .disable()" name="should set the value to false" time="0.001"/>
<testcase classname="config .enabled()" name="should default to false" time="0"/>
<testcase classname="config .enabled()" name="should return true when set" time="0"/>
<testcase classname="config .disabled()" name="should default to true" time="0"/>
<testcase classname="config .disabled()" name="should return false when set" time="0"/>
<testcase classname="exports" name="should expose Router" time="0"/>
<testcase classname="exports" name="should expose the application prototype" time="0"/>
<testcase classname="exports" name="should expose the request prototype" time="0"/>
<testcase classname="exports" name="should expose the response prototype" time="0"/>
<testcase classname="exports" name="should permit modifying the .application prototype" time="0"/>
<testcase classname="exports" name="should permit modifying the .request prototype" time="0.002"/>
<testcase classname="exports" name="should permit modifying the .response prototype" time="0.002"/>
<testcase classname="exports" name="should throw on old middlewares" time="0.001"/>
<testcase classname="middleware .next()" name="should behave like connect" time="0.005"/>
<testcase classname="throw after .end()" name="should fail gracefully" time="0.005"/>
<testcase classname="req" name="should accept an argument list of type names" time="0.005"/>
<testcase classname="req .accepts(type)" name="should return true when Accept is not present" time="0.003"/>
<testcase classname="req .accepts(type)" name="should return true when present" time="0.006"/>
<testcase classname="req .accepts(type)" name="should return false otherwise" time="0.004"/>
<testcase classname="req .accepts(types)" name="should return the first when Accept is not present" time="0.003"/>
<testcase classname="req .accepts(types)" name="should return the first acceptable type" time="0.003"/>
<testcase classname="req .accepts(types)" name="should return false when no match is made" time="0.004"/>
<testcase classname="req .accepts(types)" name="should take quality into account" time="0.004"/>
<testcase classname="req .accepts(types)" name="should return the first acceptable type with canonical mime types" time="0.002"/>
<testcase classname="req .acceptsCharset(type) when Accept-Charset is not present" name="should return true" time="0.003"/>
<testcase classname="req .acceptsCharset(type) when Accept-Charset is not present" name="should return true when present" time="0.003"/>
<testcase classname="req .acceptsCharset(type) when Accept-Charset is not present" name="should return false otherwise" time="0.004"/>
<testcase classname="req .acceptsCharsets(type) when Accept-Charset is not present" name="should return true" time="0.004"/>
<testcase classname="req .acceptsCharsets(type) when Accept-Charset is not present" name="should return true when present" time="0.003"/>
<testcase classname="req .acceptsCharsets(type) when Accept-Charset is not present" name="should return false otherwise" time="0.003"/>
<testcase classname="req .acceptsEncoding" name="should be true if encoding accpeted" time="0.004"/>
<testcase classname="req .acceptsEncoding" name="should be false if encoding not accpeted" time="0.006"/>
<testcase classname="req .acceptsEncodingss" name="should be true if encoding accpeted" time="0.007"/>
<testcase classname="req .acceptsEncodingss" name="should be false if encoding not accpeted" time="0.005"/>
<testcase classname="req .acceptsLanguage" name="should be true if language accpeted" time="0.005"/>
<testcase classname="req .acceptsLanguage" name="should be false if language not accpeted" time="0.003"/>
<testcase classname="req .acceptsLanguage when Accept-Language is not present" name="should always return true" time="0.002"/>
<testcase classname="req .acceptsLanguages" name="should be true if language accpeted" time="0.001"/>
<testcase classname="req .acceptsLanguages" name="should be false if language not accpeted" time="0.001"/>
<testcase classname="req .acceptsLanguages when Accept-Language is not present" name="should always return true" time="0.002"/>
<testcase classname="req .baseUrl" name="should be empty for top-level route" time="0.003"/>
<testcase classname="req .baseUrl" name="should contain lower path" time="0.003"/>
<testcase classname="req .baseUrl" name="should contain full lower path" time="0.003"/>
<testcase classname="req .baseUrl" name="should travel through routers correctly" time="0.003"/>
<testcase classname="req .fresh" name="should return true when the resource is not modified" time="0.006"/>
<testcase classname="req .fresh" name="should return false when the resource is modified" time="0.004"/>
<testcase classname="req .fresh" name="should return false without response headers" time="0.003"/>
<testcase classname="req .get(field)" name="should return the header field value" time="0.002"/>
<testcase classname="req .get(field)" name="should special-case Referer" time="0.002"/>
<testcase classname="req .host" name="should return the Host when present" time="0.005"/>
<testcase classname="req .host" name="should strip port number" time="0.004"/>
<testcase classname="req .host" name="should return undefined otherwise" time="0.002"/>
<testcase classname="req .host" name="should work with IPv6 Host" time="0.002"/>
<testcase classname="req .host" name="should work with IPv6 Host and port" time="0.002"/>
<testcase classname="req .host when &quot;trust proxy&quot; is enabled" name="should respect X-Forwarded-Host" time="0.009"/>
<testcase classname="req .host when &quot;trust proxy&quot; is enabled" name="should ignore X-Forwarded-Host if socket addr not trusted" time="0.012"/>
<testcase classname="req .host when &quot;trust proxy&quot; is enabled" name="should default to Host" time="0.006"/>
<testcase classname="req .host when &quot;trust proxy&quot; is enabled when trusting hop count" name="should respect X-Forwarded-Host" time="0.003"/>
<testcase classname="req .host when &quot;trust proxy&quot; is disabled" name="should ignore X-Forwarded-Host" time="0.002"/>
<testcase classname="req .hostname" name="should return the Host when present" time="0.004"/>
<testcase classname="req .hostname" name="should strip port number" time="0.004"/>
<testcase classname="req .hostname" name="should return undefined otherwise" time="0.002"/>
<testcase classname="req .hostname" name="should work with IPv6 Host" time="0.002"/>
<testcase classname="req .hostname" name="should work with IPv6 Host and port" time="0.002"/>
<testcase classname="req .hostname when &quot;trust proxy&quot; is enabled" name="should respect X-Forwarded-Host" time="0.002"/>
<testcase classname="req .hostname when &quot;trust proxy&quot; is enabled" name="should ignore X-Forwarded-Host if socket addr not trusted" time="0.005"/>
<testcase classname="req .hostname when &quot;trust proxy&quot; is enabled" name="should default to Host" time="0.003"/>
<testcase classname="req .hostname when &quot;trust proxy&quot; is disabled" name="should ignore X-Forwarded-Host" time="0.003"/>
<testcase classname="req .ip when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should return the client addr" time="0.018"/>
<testcase classname="req .ip when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should return the addr after trusted proxy" time="0.002"/>
<testcase classname="req .ip when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should return the addr after trusted proxy, from sub app" time="0.005"/>
<testcase classname="req .ip when X-Forwarded-For is present when &quot;trust proxy&quot; is disabled" name="should return the remote address" time="0.003"/>
<testcase classname="req .ip when X-Forwarded-For is not present" name="should return the remote address" time="0.002"/>
<testcase classname="req .ips when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should return an array of the specified addresses" time="0.004"/>
<testcase classname="req .ips when X-Forwarded-For is present when &quot;trust proxy&quot; is enabled" name="should stop at first untrusted" time="0.002"/>
<testcase classname="req .ips when X-Forwarded-For is present when &quot;trust proxy&quot; is disabled" name="should return an empty array" time="0.005"/>
<testcase classname="req .ips when X-Forwarded-For is not present" name="should return []" time="0.004"/>
<testcase classname="req.is()" name="should ignore charset" time="0.002"/>
<testcase classname="req.is() when content-type is not present" name="should return false" time="0"/>
<testcase classname="req.is() when given an extension" name="should lookup the mime type" time="0.001"/>
<testcase classname="req.is() when given a mime type" name="should match" time="0"/>
<testcase classname="req.is() when given */subtype" name="should match" time="0"/>
<testcase classname="req.is() when given */subtype with a charset" name="should match" time="0"/>
<testcase classname="req.is() when given type/*" name="should match" time="0"/>
<testcase classname="req.is() when given type/* with a charset" name="should match" time="0"/>
<testcase classname="req .param(name, default)" name="should use the default value unless defined" time="0.003"/>
<testcase classname="req .param(name)" name="should check req.query" time="0.005"/>
<testcase classname="req .param(name)" name="should check req.body" time="0.023"/>
<testcase classname="req .param(name)" name="should check req.params" time="0.003"/>
<testcase classname="req .path" name="should return the parsed pathname" time="0.002"/>
<testcase classname="req .protocol" name="should return the protocol string" time="0.003"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled" name="should respect X-Forwarded-Proto" time="0.004"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled" name="should default to the socket addr if X-Forwarded-Proto not present" time="0.004"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled" name="should ignore X-Forwarded-Proto if socket addr not trusted" time="0.003"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled" name="should default to http" time="0.003"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is enabled when trusting hop count" name="should respect X-Forwarded-Proto" time="0.005"/>
<testcase classname="req .protocol when &quot;trust proxy&quot; is disabled" name="should ignore X-Forwarded-Proto" time="0.004"/>
<testcase classname="req .query" name="should default to {}" time="0.003"/>
<testcase classname="req .query" name="should default to parse complex keys" time="0.002"/>
<testcase classname="req .query when &quot;query parser&quot; is extended" name="should parse complex keys" time="0.005"/>
<testcase classname="req .query when &quot;query parser&quot; is extended" name="should parse parameters with dots" time="0.003"/>
<testcase classname="req .query when &quot;query parser&quot; is simple" name="should not parse complex keys" time="0.002"/>
<testcase classname="req .query when &quot;query parser&quot; is a function" name="should parse using function" time="0.003"/>
<testcase classname="req .query when &quot;query parser&quot; disabled" name="should not parse query" time="0.003"/>
<testcase classname="req .query when &quot;query parser&quot; disabled" name="should not parse complex keys" time="0.004"/>
<testcase classname="req .query when &quot;query parser fn&quot; is missing" name="should act like &quot;extended&quot;" time="0.005"/>
<testcase classname="req .query when &quot;query parser&quot; an unknown value" name="should throw" time="0.001"/>
<testcase classname="req .range(size)" name="should return parsed ranges" time="0.001"/>
<testcase classname="req .range(size)" name="should cap to the given size" time="0"/>
<testcase classname="req .range(size)" name="should have a .type" time="0.001"/>
<testcase classname="req .range(size)" name="should return undefined if no range" time="0"/>
<testcase classname="req .route" name="should be the executed Route" time="0.003"/>
<testcase classname="req .secure when X-Forwarded-Proto is missing" name="should return false when http" time="0.009"/>
<testcase classname="req .secure when X-Forwarded-Proto is present" name="should return false when http" time="0.003"/>
<testcase classname="req .secure when X-Forwarded-Proto is present" name="should return true when &quot;trust proxy&quot; is enabled" time="0.002"/>
<testcase classname="req .secure when X-Forwarded-Proto is present" name="should return false when initial proxy is http" time="0.003"/>
<testcase classname="req .secure when X-Forwarded-Proto is present" name="should return true when initial proxy is https" time="0.004"/>
<testcase classname="req .secure when X-Forwarded-Proto is present when &quot;trust proxy&quot; trusting hop count" name="should respect X-Forwarded-Proto" time="0.003"/>
<testcase classname="req .signedCookies" name="should return a signed JSON cookie" time="0.008"/>
<testcase classname="req .stale" name="should return false when the resource is not modified" time="0.003"/>
<testcase classname="req .stale" name="should return true when the resource is modified" time="0.004"/>
<testcase classname="req .stale" name="should return true without response headers" time="0.003"/>
<testcase classname="req .subdomains when present" name="should return an array" time="0.008"/>
<testcase classname="req .subdomains when present" name="should work with IPv4 address" time="0.005"/>
<testcase classname="req .subdomains when present" name="should work with IPv6 address" time="0.003"/>
<testcase classname="req .subdomains otherwise" name="should return an empty array" time="0.002"/>
<testcase classname="req .subdomains with no host" name="should return an empty array" time="0.005"/>
<testcase classname="req .subdomains with trusted X-Forwarded-Host" name="should return an array" time="0.003"/>
<testcase classname="req .subdomains when subdomain offset is set when subdomain offset is zero" name="should return an array with the whole domain" time="0.002"/>
<testcase classname="req .subdomains when subdomain offset is set when subdomain offset is zero" name="should return an array with the whole IPv4" time="0.002"/>
<testcase classname="req .subdomains when subdomain offset is set when subdomain offset is zero" name="should return an array with the whole IPv6" time="0.002"/>
<testcase classname="req .subdomains when subdomain offset is set when present" name="should return an array" time="0.01"/>
<testcase classname="req .subdomains when subdomain offset is set otherwise" name="should return an empty array" time="0.003"/>
<testcase classname="req .xhr" name="should return true when X-Requested-With is xmlhttprequest" time="0.004"/>
<testcase classname="req .xhr" name="should case-insensitive" time="0.006"/>
<testcase classname="req .xhr" name="should return false otherwise" time="0.004"/>
<testcase classname="req .xhr" name="should return false when not present" time="0.003"/>
<testcase classname="res .append(field, val)" name="should append multiple headers" time="0.003"/>
<testcase classname="res .append(field, val)" name="should accept array of values" time="0.004"/>
<testcase classname="res .append(field, val)" name="should get reset by res.set(field, val)" time="0.003"/>
<testcase classname="res .append(field, val)" name="should work with res.set(field, val) first" time="0.003"/>
<testcase classname="res .append(field, val)" name="should work with cookies" time="0.002"/>
<testcase classname="res .attachment()" name="should Content-Disposition to attachment" time="0.003"/>
<testcase classname="res .attachment(filename)" name="should add the filename param" time="0.003"/>
<testcase classname="res .attachment(filename)" name="should set the Content-Type" time="0.004"/>
<testcase classname="res .attachment(utf8filename)" name="should add the filename and filename* params" time="0.005"/>
<testcase classname="res .attachment(utf8filename)" name="should set the Content-Type" time="0.003"/>
<testcase classname="res .clearCookie(name)" name="should set a cookie passed expiry" time="0.01"/>
<testcase classname="res .clearCookie(name, options)" name="should set the given params" time="0.004"/>
<testcase classname="res .cookie(name, object)" name="should generate a JSON cookie" time="0.003"/>
<testcase classname="res .cookie(name, string)" name="should set a cookie" time="0.005"/>
<testcase classname="res .cookie(name, string)" name="should allow multiple calls" time="0.005"/>
<testcase classname="res .cookie(name, string, options)" name="should set params" time="0.002"/>
<testcase classname="res .cookie(name, string, options) maxAge" name="should set relative expires" time="0.002"/>
<testcase classname="res .cookie(name, string, options) maxAge" name="should set max-age" time="0.003"/>
<testcase classname="res .cookie(name, string, options) maxAge" name="should not mutate the options object" time="0.004"/>
<testcase classname="res .cookie(name, string, options) signed" name="should generate a signed JSON cookie" time="0.004"/>
<testcase classname="res .cookie(name, string, options) .signedCookie(name, string)" name="should set a signed cookie" time="0.004"/>
<testcase classname="res .download(path)" name="should transfer as an attachment" time="0.015"/>
<testcase classname="res .download(path, filename)" name="should provide an alternate filename" time="0.005"/>
<testcase classname="res .download(path, fn)" name="should invoke the callback" time="0.005"/>
<testcase classname="res .download(path, filename, fn)" name="should invoke the callback" time="0.003"/>
<testcase classname="res on failure" name="should invoke the callback" time="0.003"/>
<testcase classname="res on failure" name="should remove Content-Disposition" time="0.003"/>
<testcase classname="res .format(obj) with canonicalized mime types" name="should utilize qvalues in negotiation" time="0.003"/>
<testcase classname="res .format(obj) with canonicalized mime types" name="should allow wildcard type/subtypes" time="0.004"/>
<testcase classname="res .format(obj) with canonicalized mime types" name="should default the Content-Type" time="0.004"/>
<testcase classname="res .format(obj) with canonicalized mime types" name="should set the correct  charset for the Content-Type" time="0.001"/>
<testcase classname="res .format(obj) with canonicalized mime types" name="should Vary: Accept" time="0.002"/>
<testcase classname="res .format(obj) with canonicalized mime types when Accept is not present" name="should invoke the first callback" time="0.002"/>
<testcase classname="res .format(obj) with canonicalized mime types when no match is made" name="should should respond with 406 not acceptable" time="0.006"/>
<testcase classname="res .format(obj) with extnames" name="should utilize qvalues in negotiation" time="0.004"/>
<testcase classname="res .format(obj) with extnames" name="should allow wildcard type/subtypes" time="0.015"/>
<testcase classname="res .format(obj) with extnames" name="should default the Content-Type" time="0.002"/>
<testcase classname="res .format(obj) with extnames" name="should set the correct  charset for the Content-Type" time="0"/>
<testcase classname="res .format(obj) with extnames" name="should Vary: Accept" time="0.002"/>
<testcase classname="res .format(obj) with extnames when Accept is not present" name="should invoke the first callback" time="0.002"/>
<testcase classname="res .format(obj) with extnames when no match is made" name="should should respond with 406 not acceptable" time="0.006"/>
<testcase classname="res .format(obj) with parameters" name="should utilize qvalues in negotiation" time="0.005"/>
<testcase classname="res .format(obj) with parameters" name="should allow wildcard type/subtypes" time="0.002"/>
<testcase classname="res .format(obj) with parameters" name="should default the Content-Type" time="0.002"/>
<testcase classname="res .format(obj) with parameters" name="should set the correct  charset for the Content-Type" time="0.003"/>
<testcase classname="res .format(obj) with parameters" name="should Vary: Accept" time="0.004"/>
<testcase classname="res .format(obj) with parameters when Accept is not present" name="should invoke the first callback" time="0.002"/>
<testcase classname="res .format(obj) with parameters when no match is made" name="should should respond with 406 not acceptable" time="0.002"/>
<testcase classname="res .format(obj) given .default" name="should be invoked instead of auto-responding" time="0.002"/>
<testcase classname="res .format(obj) given .default" name="should work when only .default is provided" time="0.004"/>
<testcase classname="res .format(obj) in router" name="should utilize qvalues in negotiation" time="0.003"/>
<testcase classname="res .format(obj) in router" name="should allow wildcard type/subtypes" time="0.003"/>
<testcase classname="res .format(obj) in router" name="should default the Content-Type" time="0.002"/>
<testcase classname="res .format(obj) in router" name="should set the correct  charset for the Content-Type" time="0.001"/>
<testcase classname="res .format(obj) in router" name="should Vary: Accept" time="0.003"/>
<testcase classname="res .format(obj) in router when Accept is not present" name="should invoke the first callback" time="0.005"/>
<testcase classname="res .format(obj) in router when no match is made" name="should should respond with 406 not acceptable" time="0.005"/>
<testcase classname="res .format(obj) in router" name="should utilize qvalues in negotiation" time="0.004"/>
<testcase classname="res .format(obj) in router" name="should allow wildcard type/subtypes" time="0.007"/>
<testcase classname="res .format(obj) in router" name="should default the Content-Type" time="0.005"/>
<testcase classname="res .format(obj) in router" name="should set the correct  charset for the Content-Type" time="0.001"/>
<testcase classname="res .format(obj) in router" name="should Vary: Accept" time="0.003"/>
<testcase classname="res .format(obj) in router when Accept is not present" name="should invoke the first callback" time="0.003"/>
<testcase classname="res .format(obj) in router when no match is made" name="should should respond with 406 not acceptable" time="0.007"/>
<testcase classname="res .get(field)" name="should get the response header field" time="0.003"/>
<testcase classname="res .json(object)" name="should not support jsonp callbacks" time="0.002"/>
<testcase classname="res .json(object)" name="should not override previous Content-Types" time="0.003"/>
<testcase classname="res .json(object) when given primitives" name="should respond with json for null" time="0.005"/>
<testcase classname="res .json(object) when given primitives" name="should respond with json for Number" time="0.004"/>
<testcase classname="res .json(object) when given primitives" name="should respond with json for String" time="0.003"/>
<testcase classname="res .json(object) when given an array" name="should respond with json" time="0.003"/>
<testcase classname="res .json(object) when given an object" name="should respond with json" time="0.004"/>
<testcase classname="res .json(object) &quot;json replacer&quot; setting" name="should be passed to JSON.stringify()" time="0.006"/>
<testcase classname="res .json(object) &quot;json spaces&quot; setting" name="should be undefined by default" time="0.001"/>
<testcase classname="res .json(object) &quot;json spaces&quot; setting" name="should be passed to JSON.stringify()" time="0.003"/>
<testcase classname="res .json(status, object)" name="should respond with json and set the .statusCode" time="0.005"/>
<testcase classname="res .json(object, status)" name="should respond with json and set the .statusCode for backwards compat" time="0.003"/>
<testcase classname="res .json(object, status)" name="should use status as second number for backwards compat" time="0.003"/>
<testcase classname="res" name="should not override previous Content-Types" time="0.003"/>
<testcase classname="res .jsonp(object)" name="should respond with jsonp" time="0.002"/>
<testcase classname="res .jsonp(object)" name="should use first callback parameter with jsonp" time="0.005"/>
<testcase classname="res .jsonp(object)" name="should ignore object callback parameter with jsonp" time="0.005"/>
<testcase classname="res .jsonp(object)" name="should allow renaming callback" time="0.004"/>
<testcase classname="res .jsonp(object)" name="should allow []" time="0.003"/>
<testcase classname="res .jsonp(object)" name="should disallow arbitrary js" time="0.005"/>
<testcase classname="res .jsonp(object)" name="should escape utf whitespace" time="0.005"/>
<testcase classname="res .jsonp(object)" name="should not escape utf whitespace for json fallback" time="0.003"/>
<testcase classname="res .jsonp(object)" name="should include security header and prologue" time="0.002"/>
<testcase classname="res .jsonp(object)" name="should not override previous Content-Types with no callback" time="0.005"/>
<testcase classname="res .jsonp(object)" name="should override previous Content-Types with callback" time="0.003"/>
<testcase classname="res .jsonp(object) when given primitives" name="should respond with json" time="0.003"/>
<testcase classname="res .jsonp(object) when given an array" name="should respond with json" time="0.003"/>
<testcase classname="res .jsonp(object) when given an object" name="should respond with json" time="0.003"/>
<testcase classname="res .jsonp(object) when given primitives" name="should respond with json for null" time="0.006"/>
<testcase classname="res .jsonp(object) when given primitives" name="should respond with json for Number" time="0.005"/>
<testcase classname="res .jsonp(object) when given primitives" name="should respond with json for String" time="0.005"/>
<testcase classname="res .jsonp(object) &quot;json replacer&quot; setting" name="should be passed to JSON.stringify()" time="0.014"/>
<testcase classname="res .jsonp(object) &quot;json spaces&quot; setting" name="should be undefined by default" time="0"/>
<testcase classname="res .jsonp(object) &quot;json spaces&quot; setting" name="should be passed to JSON.stringify()" time="0.005"/>
<testcase classname="res .jsonp(status, object)" name="should respond with json and set the .statusCode" time="0.004"/>
<testcase classname="res .jsonp(object, status)" name="should respond with json and set the .statusCode for backwards compat" time="0.003"/>
<testcase classname="res .jsonp(object, status)" name="should use status as second number for backwards compat" time="0.002"/>
<testcase classname="res .links(obj)" name="should set Link header field" time="0.002"/>
<testcase classname="res .links(obj)" name="should set Link header field for multiple calls" time="0.003"/>
<testcase classname="res" name="should work when mounted" time="0.005"/>
<testcase classname="res .locals" name="should be empty by default" time="0.003"/>
<testcase classname="res .location(url)" name="should set the header" time="0.003"/>
<testcase classname="res .redirect(url)" name="should default to a 302 redirect" time="0.004"/>
<testcase classname="res .redirect(status, url)" name="should set the response status" time="0.007"/>
<testcase classname="res .redirect(url, status)" name="should set the response status" time="0.005"/>
<testcase classname="res when the request method is HEAD" name="should ignore the body" time="0.003"/>
<testcase classname="res when accepting html" name="should respond with html" time="0.003"/>
<testcase classname="res when accepting html" name="should escape the url" time="0.005"/>
<testcase classname="res when accepting html" name="should include the redirect type" time="0.003"/>
<testcase classname="res when accepting text" name="should respond with text" time="0.003"/>
<testcase classname="res when accepting text" name="should encode the url" time="0.002"/>
<testcase classname="res when accepting text" name="should include the redirect type" time="0.003"/>
<testcase classname="res when accepting neither text or html" name="should respond with an empty body" time="0.005"/>
<testcase classname="res .render(name)" name="should support absolute paths" time="0.005"/>
<testcase classname="res .render(name)" name="should support absolute paths with &quot;view engine&quot;" time="0.004"/>
<testcase classname="res .render(name)" name="should error without &quot;view engine&quot; set and no file extension" time="0.006"/>
<testcase classname="res .render(name)" name="should expose app.locals" time="0.005"/>
<testcase classname="res .render(name)" name="should expose app.locals with `name` property" time="0.004"/>
<testcase classname="res .render(name)" name="should support index.&lt;engine&gt;" time="0.003"/>
<testcase classname="res .render(name) when an error occurs" name="should next(err)" time="0.006"/>
<testcase classname="res .render(name) when &quot;view engine&quot; is given" name="should render the template" time="0.004"/>
<testcase classname="res .render(name) when &quot;views&quot; is given" name="should lookup the file in the path" time="0.002"/>
<testcase classname="res .render(name) when &quot;views&quot; is given when array of paths" name="should lookup the file in the path" time="0.003"/>
<testcase classname="res .render(name) when &quot;views&quot; is given when array of paths" name="should lookup in later paths until found" time="0.004"/>
<testcase classname="res .render(name, option)" name="should render the template" time="0.004"/>
<testcase classname="res .render(name, option)" name="should expose app.locals" time="0.004"/>
<testcase classname="res .render(name, option)" name="should expose res.locals" time="0.003"/>
<testcase classname="res .render(name, option)" name="should give precedence to res.locals over app.locals" time="0.007"/>
<testcase classname="res .render(name, option)" name="should give precedence to res.render() locals over res.locals" time="0.007"/>
<testcase classname="res .render(name, option)" name="should give precedence to res.render() locals over app.locals" time="0.003"/>
<testcase classname="res .render(name, options, fn)" name="should pass the resulting string" time="0.005"/>
<testcase classname="res .render(name, fn)" name="should pass the resulting string" time="0.004"/>
<testcase classname="res .render(name, fn) when an error occurs" name="should pass it to the callback" time="0.003"/>
<testcase classname="res" name="should always check regardless of length" time="0.002"/>
<testcase classname="res" name="should respond with 304 Not Modified when fresh" time="0.002"/>
<testcase classname="res" name="should not perform freshness check unless 2xx or 304" time="0.003"/>
<testcase classname="res" name="should not support jsonp callbacks" time="0.021"/>
<testcase classname="res .send()" name="should set body to &quot;&quot;" time="0.005"/>
<testcase classname="res .send(null)" name="should set body to &quot;&quot;" time="0.002"/>
<testcase classname="res .send(undefined)" name="should set body to &quot;&quot;" time="0.002"/>
<testcase classname="res .send(code)" name="should set .statusCode" time="0.005"/>
<testcase classname="res .send(code, body)" name="should set .statusCode and body" time="0.003"/>
<testcase classname="res .send(body, code)" name="should be supported for backwards compat" time="0.003"/>
<testcase classname="res .send(code, number)" name="should send number as json" time="0.002"/>
<testcase classname="res .send(String)" name="should send as html" time="0.002"/>
<testcase classname="res .send(String)" name="should set ETag" time="0.004"/>
<testcase classname="res .send(String)" name="should not override Content-Type" time="0.004"/>
<testcase classname="res .send(String)" name="should override charset in Content-Type" time="0.004"/>
<testcase classname="res .send(String)" name="should keep charset in Content-Type for Buffers" time="0.003"/>
<testcase classname="res .send(Buffer)" name="should send as octet-stream" time="0.004"/>
<testcase classname="res .send(Buffer)" name="should set ETag" time="0.006"/>
<testcase classname="res .send(Buffer)" name="should not override Content-Type" time="0.005"/>
<testcase classname="res .send(Object)" name="should send as application/json" time="0.003"/>
<testcase classname="res when the request method is HEAD" name="should ignore the body" time="0.002"/>
<testcase classname="res when .statusCode is 204" name="should strip Content-* fields, Transfer-Encoding field, and body" time="0.006"/>
<testcase classname="res when .statusCode is 304" name="should strip Content-* fields, Transfer-Encoding field, and body" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to ACL request" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to BIND request" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to CHECKOUT request" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to COPY request" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to DELETE request" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to GET request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to HEAD request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to LINK request" time="0.007"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to LOCK request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to M-SEARCH request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to MERGE request" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to MKACTIVITY request" time="0.005"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to MKCALENDAR request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to MKCOL request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to MOVE request" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to NOTIFY request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to OPTIONS request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to PATCH request" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to POST request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to PROPFIND request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to PROPPATCH request" time="0.007"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to PURGE request" time="0.005"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to PUT request" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to REBIND request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to REPORT request" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to SEARCH request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to SUBSCRIBE request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to TRACE request" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to UNBIND request" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to UNLINK request" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to UNLOCK request" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag in response to UNSUBSCRIBE request" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag for empty string response" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should send ETag for long response" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should not override ETag when manually set" time="0.006"/>
<testcase classname="res &quot;etag&quot; setting when enabled" name="should not send ETag for res.send()" time="0.005"/>
<testcase classname="res &quot;etag&quot; setting when disabled" name="should send no ETag" time="0.003"/>
<testcase classname="res &quot;etag&quot; setting when disabled" name="should send ETag when manually set" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when &quot;strong&quot;" name="should send strong ETag" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when &quot;weak&quot;" name="should send weak ETag" time="0.004"/>
<testcase classname="res &quot;etag&quot; setting when a function" name="should send custom ETag" time="0.002"/>
<testcase classname="res &quot;etag&quot; setting when a function" name="should not send falsy ETag" time="0.002"/>
<testcase classname="res .sendFile(path)" name="should error missing path" time="0.003"/>
<testcase classname="res .sendFile(path)" name="should transfer a file" time="0.006"/>
<testcase classname="res .sendFile(path)" name="should transfer a file with special characters in string" time="0.004"/>
<testcase classname="res .sendFile(path)" name="should include ETag" time="0.004"/>
<testcase classname="res .sendFile(path)" name="should 304 when ETag matches" time="0.014"/>
<testcase classname="res .sendFile(path)" name="should 404 for directory" time="0.003"/>
<testcase classname="res .sendFile(path)" name="should 404 when not found" time="0.003"/>
<testcase classname="res .sendFile(path)" name="should not override manual content-types" time="0.005"/>
<testcase classname="res .sendFile(path)" name="should not error if the client aborts" time="0.002"/>
<testcase classname="res .sendFile(path) with &quot;dotfiles&quot; option" name="should not serve dotfiles by default" time="0.003"/>
<testcase classname="res .sendFile(path) with &quot;dotfiles&quot; option" name="should accept dotfiles option" time="0.005"/>
<testcase classname="res .sendFile(path) with &quot;headers&quot; option" name="should accept headers option" time="0.007"/>
<testcase classname="res .sendFile(path) with &quot;headers&quot; option" name="should ignore headers option on 404" time="0.004"/>
<testcase classname="res .sendFile(path) with &quot;root&quot; option" name="should not transfer relative with without" time="0.006"/>
<testcase classname="res .sendFile(path) with &quot;root&quot; option" name="should serve relative to &quot;root&quot;" time="0.006"/>
<testcase classname="res .sendFile(path) with &quot;root&quot; option" name="should disallow requesting out of &quot;root&quot;" time="0.004"/>
<testcase classname="res .sendFile(path, fn)" name="should invoke the callback when complete" time="0.005"/>
<testcase classname="res .sendFile(path, fn)" name="should invoke the callback when client aborts" time="0.005"/>
<testcase classname="res .sendFile(path, fn)" name="should invoke the callback when client already aborted" time="0.003"/>
<testcase classname="res .sendFile(path, fn)" name="should invoke the callback without error when HEAD" time="0.002"/>
<testcase classname="res .sendFile(path, fn)" name="should invoke the callback without error when 304" time="0.008"/>
<testcase classname="res .sendFile(path, fn)" name="should invoke the callback on 404" time="0.005"/>
<testcase classname="res .sendfile(path, fn)" name="should invoke the callback when complete" time="0.004"/>
<testcase classname="res .sendfile(path, fn)" name="should utilize the same options as express.static()" time="0.006"/>
<testcase classname="res .sendfile(path, fn)" name="should invoke the callback when client aborts" time="0.005"/>
<testcase classname="res .sendfile(path, fn)" name="should invoke the callback when client already aborted" time="0.003"/>
<testcase classname="res .sendfile(path, fn)" name="should invoke the callback without error when HEAD" time="0.003"/>
<testcase classname="res .sendfile(path, fn)" name="should invoke the callback without error when 304" time="0.009"/>
<testcase classname="res .sendfile(path, fn)" name="should invoke the callback on 404" time="0.003"/>
<testcase classname="res .sendfile(path, fn)" name="should not override manual content-types" time="0.003"/>
<testcase classname="res .sendfile(path, fn)" name="should invoke the callback on 403" time="0.004"/>
<testcase classname="res .sendfile(path, fn)" name="should invoke the callback on socket error" time="0.021"/>
<testcase classname="res .sendfile(path)" name="should not serve dotfiles" time="0.004"/>
<testcase classname="res .sendfile(path)" name="should accept dotfiles option" time="0.005"/>
<testcase classname="res .sendfile(path)" name="should accept headers option" time="0.004"/>
<testcase classname="res .sendfile(path)" name="should ignore headers option on 404" time="0.003"/>
<testcase classname="res .sendfile(path)" name="should transfer a file" time="0.003"/>
<testcase classname="res .sendfile(path)" name="should transfer a directory index file" time="0.003"/>
<testcase classname="res .sendfile(path)" name="should 404 for directory without trailing slash" time="0.005"/>
<testcase classname="res .sendfile(path)" name="should transfer a file with urlencoded name" time="0.005"/>
<testcase classname="res .sendfile(path)" name="should not error if the client aborts" time="0.002"/>
<testcase classname="res .sendfile(path) with an absolute path" name="should transfer the file" time="0.008"/>
<testcase classname="res .sendfile(path) with a relative path" name="should transfer the file" time="0.004"/>
<testcase classname="res .sendfile(path) with a relative path" name="should serve relative to &quot;root&quot;" time="0.004"/>
<testcase classname="res .sendfile(path) with a relative path" name="should consider ../ malicious when &quot;root&quot; is not set" time="0.007"/>
<testcase classname="res .sendfile(path) with a relative path" name="should allow ../ when &quot;root&quot; is set" time="0.004"/>
<testcase classname="res .sendfile(path) with a relative path" name="should disallow requesting out of &quot;root&quot;" time="0.003"/>
<testcase classname="res .sendfile(path) with a relative path" name="should next(404) when not found" time="0.004"/>
<testcase classname="res .sendfile(path) with a relative path with non-GET" name="should still serve" time="0.005"/>
<testcase classname="res .sendStatus(statusCode)" name="should send the status code and message as body" time="0.005"/>
<testcase classname="res .sendStatus(statusCode)" name="should work with unknown code" time="0.003"/>
<testcase classname="res .set(field, value)" name="should set the response header field" time="0.003"/>
<testcase classname="res .set(field, value)" name="should coerce to a string" time="0.006"/>
<testcase classname="res .set(field, values)" name="should set multiple response header fields" time="0.004"/>
<testcase classname="res .set(field, values)" name="should coerce to an array of strings" time="0.002"/>
<testcase classname="res .set(field, values)" name="should not set a charset of one is already set" time="0.004"/>
<testcase classname="res .set(object)" name="should set multiple fields" time="0.004"/>
<testcase classname="res .set(object)" name="should coerce to a string" time="0.003"/>
<testcase classname="res .status(code)" name="should set the response .statusCode" time="0.002"/>
<testcase classname="res .type(str)" name="should set the Content-Type based on a filename" time="0.002"/>
<testcase classname="res .type(str)" name="should default to application/octet-stream" time="0.003"/>
<testcase classname="res .type(str)" name="should set the Content-Type with type/subtype" time="0.003"/>
<testcase classname="res.vary() with no arguments" name="should not set Vary" time="0.005"/>
<testcase classname="res.vary() with an empty array" name="should not set Vary" time="0.003"/>
<testcase classname="res.vary() with an array" name="should set the values" time="0.003"/>
<testcase classname="res.vary() with a string" name="should set the value" time="0.006"/>
<testcase classname="res.vary() when the value is present" name="should not add it again" time="0.005"/>
<testcase classname="utils.etag(body, encoding)" name="should support strings" time="0"/>
<testcase classname="utils.etag(body, encoding)" name="should support utf8 strings" time="0.001"/>
<testcase classname="utils.etag(body, encoding)" name="should support buffer" time="0"/>
<testcase classname="utils.etag(body, encoding)" name="should support empty string" time="0"/>
<testcase classname="utils.setCharset(type, charset)" name="should do anything without type" time="0"/>
<testcase classname="utils.setCharset(type, charset)" name="should return type if not given charset" time="0"/>
<testcase classname="utils.setCharset(type, charset)" name="should keep charset if not given charset" time="0"/>
<testcase classname="utils.setCharset(type, charset)" name="should set charset" time="0"/>
<testcase classname="utils.setCharset(type, charset)" name="should override charset" time="0"/>
<testcase classname="utils.wetag(body, encoding)" name="should support strings" time="0"/>
<testcase classname="utils.wetag(body, encoding)" name="should support utf8 strings" time="0"/>
<testcase classname="utils.wetag(body, encoding)" name="should support buffer" time="0"/>
<testcase classname="utils.wetag(body, encoding)" name="should support empty string" time="0"/>
<testcase classname="utils.isAbsolute()" name="should support windows" time="0"/>
<testcase classname="utils.isAbsolute()" name="should support windows unc" time="0"/>
<testcase classname="utils.isAbsolute()" name="should support unices" time="0"/>
<testcase classname="utils.flatten(arr)" name="should flatten an array" time="0"/>
<testcase classname="auth GET /" name="should redirect to /login" time="0.006"/>
<testcase classname="auth GET /login" name="should render login form" time="0.008"/>
<testcase classname="auth GET /login" name="should display login error" time="0.012"/>
<testcase classname="auth GET /logout" name="should redirect to /" time="0.005"/>
<testcase classname="auth GET /restricted" name="should redirect to /login without cookie" time="0.004"/>
<testcase classname="auth GET /restricted" name="should succeed with proper cookie" time="0.09"/>
<testcase classname="auth POST /login" name="should fail without proper username" time="0.005"/>
<testcase classname="auth POST /login" name="should fail without proper password" time="0.087"/>
<testcase classname="auth POST /login" name="should succeed with proper credentials" time="0.09"/>
<testcase classname="content-negotiation GET /" name="should default to text/html" time="0.004"/>
<testcase classname="content-negotiation GET /" name="should accept to text/plain" time="0.002"/>
<testcase classname="content-negotiation GET /" name="should accept to application/json" time="0.002"/>
<testcase classname="content-negotiation GET /users" name="should default to text/html" time="0.002"/>
<testcase classname="content-negotiation GET /users" name="should accept to text/plain" time="0.003"/>
<testcase classname="content-negotiation GET /users" name="should accept to application/json" time="0.004"/>
<testcase classname="cookie-sessions GET /" name="should display no views" time="0.007"/>
<testcase classname="cookie-sessions GET /" name="should set a session cookie" time="0.003"/>
<testcase classname="cookie-sessions GET /" name="should display 1 view on revisit" time="0.012"/>
<testcase classname="cookies GET /" name="should have a form" time="0.003"/>
<testcase classname="cookies GET /" name="should respond with no cookies" time="0.002"/>
<testcase classname="cookies GET /" name="should respond to cookie" time="0.01"/>
<testcase classname="cookies GET /forget" name="should clear cookie" time="0.004"/>
<testcase classname="cookies POST /" name="should set a cookie" time="0.003"/>
<testcase classname="cookies POST /" name="should no set cookie w/o reminder" time="0.007"/>
<testcase classname="downloads GET /" name="should have a link to amazing.txt" time="0.004"/>
<testcase classname="downloads GET /files/amazing.txt" name="should have a download header" time="0.006"/>
<testcase classname="downloads GET /files/missing.txt" name="should respond with 404" time="0.009"/>
<testcase classname="ejs GET /" name="should respond with html" time="0.004"/>
<testcase classname="error-pages GET /" name="should respond with page list" time="0.002"/>
<testcase classname="error-pages Accept: text/html GET /403" name="should respond with 403" time="0.006"/>
<testcase classname="error-pages Accept: text/html GET /404" name="should respond with 404" time="0.005"/>
<testcase classname="error-pages Accept: text/html GET /500" name="should respond with 500" time="0.003"/>
<testcase classname="error-pages Accept: application/json GET /403" name="should respond with 403" time="0.003"/>
<testcase classname="error-pages Accept: application/json GET /404" name="should respond with 404" time="0.005"/>
<testcase classname="error-pages Accept: application/json GET /500" name="should respond with 500" time="0.005"/>
<testcase classname="error-pages Accept: text/plain GET /403" name="should respond with 403" time="0.004"/>
<testcase classname="error-pages Accept: text/plain GET /404" name="should respond with 404" time="0.003"/>
<testcase classname="error-pages Accept: text/plain GET /500" name="should respond with 500" time="0.008"/>
<testcase classname="error GET /" name="should respond with 500" time="0.003"/>
<testcase classname="error GET /next" name="should respond with 500" time="0.002"/>
<testcase classname="error GET /missing" name="should respond with 404" time="0.003"/>
<testcase classname="markdown GET /" name="should respond with html" time="0.009"/>
<testcase classname="markdown GET /fail" name="should respond with an error" time="0.002"/>
<testcase classname="multi-router GET /" name="should respond with root handler" time="0.002"/>
<testcase classname="multi-router GET /api/v1/" name="should respond with APIv1 root handler" time="0.003"/>
<testcase classname="multi-router GET /api/v1/users" name="should respond with users from APIv1" time="0.004"/>
<testcase classname="multi-router GET /api/v2/" name="should respond with APIv2 root handler" time="0.004"/>
<testcase classname="multi-router GET /api/v2/users" name="should respond with users from APIv2" time="0.004"/>
<testcase classname="mvc GET /" name="should redirect to /users" time="0.005"/>
<testcase classname="mvc GET /pet/0" name="should get pet" time="0.008"/>
<testcase classname="mvc GET /pet/0/edit" name="should get pet edit page" time="0.004"/>
<testcase classname="mvc PUT /pet/2" name="should update the pet" time="0.011"/>
<testcase classname="mvc GET /users" name="should display a list of users" time="0.375"/>
<testcase classname="mvc GET /user/:id when present" name="should display the user" time="0.074"/>
<testcase classname="mvc GET /user/:id when present" name="should display the users pets" time="0.037"/>
<testcase classname="mvc GET /user/:id when not present" name="should 404" time="0.008"/>
<testcase classname="mvc GET /user/:id/edit" name="should display the edit form" time="0.033"/>
<testcase classname="mvc PUT /user/:id" name="should 500 on error" time="0.009"/>
<testcase classname="mvc PUT /user/:id" name="should update the user" time="0.02"/>
<testcase classname="mvc POST /user/:id/pet" name="should create a pet for user" time="0.029"/>
<testcase classname="params GET /" name="should respond with instructions" time="0.003"/>
<testcase classname="params GET /user/0" name="should respond with a user" time="0.003"/>
<testcase classname="params GET /user/9" name="should fail to find user" time="0.005"/>
<testcase classname="params GET /users/0-2" name="should respond with three users" time="0.003"/>
<testcase classname="params GET /users/foo-bar" name="should fail integer parsing" time="0.003"/>
<testcase classname="resource GET /" name="should respond with instructions" time="0.002"/>
<testcase classname="resource GET /users" name="should respond with all users" time="0.004"/>
<testcase classname="resource GET /users/1" name="should respond with user 1" time="0.004"/>
<testcase classname="resource GET /users/9" name="should respond with error" time="0.004"/>
<testcase classname="resource GET /users/1..3" name="should respond with users 1 through 3" time="0.004"/>
<testcase classname="resource DELETE /users/1" name="should delete user 1" time="0.006"/>
<testcase classname="resource DELETE /users/9" name="should fail" time="0.005"/>
<testcase classname="resource GET /users/1..3.json" name="should respond with users 2 and 3 as json" time="0.003"/>
<testcase classname="route-map GET /users" name="should respond with users" time="0.002"/>
<testcase classname="route-map DELETE /users" name="should delete users" time="0.003"/>
<testcase classname="route-map GET /users/:id" name="should get a user" time="0.011"/>
<testcase classname="route-map GET /users/:id/pets" name="should get a users pets" time="0.002"/>
<testcase classname="route-map GET /users/:id/pets/:pid" name="should get a users pet" time="0.002"/>
<testcase classname="route-separation GET /" name="should respond with index" time="0.022"/>
<testcase classname="route-separation GET /users" name="should list users" time="0.018"/>
<testcase classname="route-separation GET /user/:id" name="should get a user" time="0.009"/>
<testcase classname="route-separation GET /user/:id" name="should 404 on missing user" time="0.006"/>
<testcase classname="route-separation GET /user/:id/view" name="should get a user" time="0.012"/>
<testcase classname="route-separation GET /user/:id/view" name="should 404 on missing user" time="0.007"/>
<testcase classname="route-separation GET /user/:id/edit" name="should get a user to edit" time="0.016"/>
<testcase classname="route-separation PUT /user/:id/edit" name="should edit a user" time="0.012"/>
<testcase classname="route-separation POST /user/:id/edit?_method=PUT" name="should edit a user" time="0.025"/>
<testcase classname="route-separation GET /posts" name="should get a list of posts" time="0.013"/>
<testcase classname="vhost example.com GET /" name="should say hello" time="0.003"/>
<testcase classname="vhost example.com GET /foo" name="should say foo" time="0.002"/>
<testcase classname="vhost foo.example.com GET /" name="should redirect to /foo" time="0.003"/>
<testcase classname="vhost bar.example.com GET /" name="should redirect to /bar" time="0.005"/>
<testcase classname="web-service GET /api/users without an api key" name="should respond with 400 bad request" time="0.005"/>
<testcase classname="web-service GET /api/users with an invalid api key" name="should respond with 401 unauthorized" time="0.003"/>
<testcase classname="web-service GET /api/users with a valid api key" name="should respond users json" time="0.004"/>
<testcase classname="web-service GET /api/repos without an api key" name="should respond with 400 bad request" time="0.006"/>
<testcase classname="web-service GET /api/repos with an invalid api key" name="should respond with 401 unauthorized" time="0.004"/>
<testcase classname="web-service GET /api/repos with a valid api key" name="should respond repos json" time="0.003"/>
<testcase classname="web-service GET /api/user/:name/repos without an api key" name="should respond with 400 bad request" time="0.002"/>
<testcase classname="web-service GET /api/user/:name/repos with an invalid api key" name="should respond with 401 unauthorized" time="0.004"/>
<testcase classname="web-service GET /api/user/:name/repos with a valid api key" name="should respond user repos json" time="0.004"/>
<testcase classname="web-service GET /api/user/:name/repos with a valid api key" name="should 404 with unknown user" time="0.002"/>
<testcase classname="web-service when requesting an invalid route" name="should respond with 404 json" time="0.002"/>
</testsuite>
